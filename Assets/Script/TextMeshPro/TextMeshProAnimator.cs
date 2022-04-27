using UnityEngine;
using TMPro;

public class TextMeshProAnimator : MonoBehaviour
{
    private TMP_Text textComponent;
    private TMP_TextInfo textInfo;
    private bool hasTextChanged = true;
    private Vector3[][] baseVertices = default;

    private void Update()
    {
        if (this.textComponent == null)
            this.textComponent = GetComponent<TMP_Text>();

        UpdateAnimation();
    }

    private void OnEnable()
    {
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(OnTextChanged);
    }

    private void OnDisable()
    {
        TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(OnTextChanged);
    }

    private void OnTextChanged(Object obj)
    {
        if (obj == this.textComponent)
            this.hasTextChanged = true;
    }

    private void UpdateAnimation()
    {
        // GC対策
        if (this.hasTextChanged)
        {
            // ① メッシュを再生成する（リセット）
            this.textComponent.ForceMeshUpdate(true);
            this.textInfo = textComponent.textInfo;

            // ForceMeshUpdate にて OnTextChanged が呼び出されるのでこのタイミングでフラグを下す
            this.hasTextChanged = false;

            // ①’ 頂点データの保存
            if (this.baseVertices == null)
                this.baseVertices = new Vector3[this.textInfo.materialCount][];

            for (int i = 0; i < textInfo.materialCount; i++)
            {
                TMP_MeshInfo meshInfo = textInfo.meshInfo[i];

                if (this.baseVertices[i] == null ||
                    this.baseVertices[i].Length != meshInfo.vertices.Length)
                    System.Array.Resize(ref this.baseVertices[i], meshInfo.vertices.Length);

                System.Array.Copy(meshInfo.vertices, this.baseVertices[i], meshInfo.vertices.Length);
            }
        }

        // ② 頂点データを編集した配列の作成
        var count = Mathf.Min(this.textInfo.characterCount, this.textInfo.characterInfo.Length);
        for (int i = 0; i < count; i++)
        {
            var charInfo = this.textInfo.characterInfo[i];
            if (!charInfo.isVisible)
                continue;

            int materialIndex = this.textInfo.characterInfo[i].materialReferenceIndex;
            int vertexIndex = this.textInfo.characterInfo[i].vertexIndex;

            Vector3[] baseVerts = this.baseVertices[materialIndex];
            Vector3[] animVerts = this.textInfo.meshInfo[materialIndex].vertices;

            // Wave
            float sinWaveOffset = 0.5f * i;
            float sinWave = Mathf.Sin(sinWaveOffset + Time.realtimeSinceStartup * Mathf.PI);
            animVerts[vertexIndex + 0].y = baseVerts[vertexIndex + 0].y + sinWave;
            animVerts[vertexIndex + 1].y = baseVerts[vertexIndex + 1].y + sinWave;
            animVerts[vertexIndex + 2].y = baseVerts[vertexIndex + 2].y + sinWave;
            animVerts[vertexIndex + 3].y = baseVerts[vertexIndex + 3].y + sinWave;
        }

        // ③ メッシュを更新
        for (int i = 0; i < textInfo.materialCount; i++)
        {
            if (this.textInfo.meshInfo[i].mesh == null) { continue; }

            textInfo.meshInfo[i].mesh.vertices = textInfo.meshInfo[i].vertices;  // 変更
            textComponent.UpdateGeometry(textInfo.meshInfo[i].mesh, i);
            textComponent.UpdateGeometry(textInfo.meshInfo[i].mesh, i);
        }
    }
}
