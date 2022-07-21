using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationRefresh : MonoBehaviour
{
    private GameObject[] MoveText;
    private TextMeshProGeometryAnimation animationDatas;
    protected float Previoustime = 0f;

    public void TextAnimationReflresh()
    {
        float nowTime = Time.time;
        if (nowTime - Previoustime > 2)
        {
            MoveText = GameObject.FindGameObjectsWithTag("MoveText");
            for (int i = 0; i < MoveText.Length; i++)
            {
                animationDatas = MoveText[i].GetComponent<TextMeshProGeometryAnimator>().animationData;
                MoveText[i].GetComponent<TextMeshProGeometryAnimator>().Refresh(true);
            }
        }
        Previoustime = nowTime;
    }
}

