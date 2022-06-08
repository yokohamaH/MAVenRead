using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChange : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject[] MoveText;
    private TextMeshProGeometryAnimator TextMeshProGeometry;

    public void positionOn()
    {
        MoveText = GameObject.FindGameObjectsWithTag("MoveText");
        Debug.Log(MoveText.Length);
        for (int i = 0; i < MoveText.Length; i++)
        {
            TextMeshProGeometry = MoveText[i].GetComponent<TextMeshProGeometryAnimator>();
            TextMeshProGeometry.animationData.position.use = true;
            TextMeshProGeometry.animationData.positionNoise.use = false; 
        }
    }
}
