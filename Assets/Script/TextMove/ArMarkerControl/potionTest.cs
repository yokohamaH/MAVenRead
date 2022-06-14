using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionTest : MonoBehaviour
{
    int time = 0;
    void Update()
    {
        time = time + 1;
        Transform CubuPosition = this.GetComponent<Transform>();
        Vector3 CubuPosition_pos = CubuPosition.transform.position;
        if (time % 100 == 0)
        {
            Debug.Log(CubuPosition_pos.x);
            Debug.Log(CubuPosition_pos.y);
            Debug.Log(CubuPosition_pos.z);

        }

        Vector3 center_obj_pos = new Vector3(CubuPosition_pos.x, CubuPosition_pos.y, CubuPosition_pos.z);
        this.transform.position = center_obj_pos;

    }
}
