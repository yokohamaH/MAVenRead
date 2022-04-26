using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArCameraFixed : MonoBehaviour
{
    // オブジェクトに紐付いている関数
    public class MainCharacter : MonoBehaviour
    {

        // 更新用の関数
        void Update()
        {

            // transformを取得
            Transform ArCameraTransform = this.transform;

            // 座標を取得
            Vector3 pos = ArCameraTransform.position;
            pos.x = 0.0f;    
            pos.y = 0.0f;    
            pos.z = 0.0f;

            ArCameraTransform.rotation=Quaternion.Euler(0, 0, 0); 
            // 座標を取

            ArCameraTransform.position = pos;  // 座標を設定
            
        }
    }
}
