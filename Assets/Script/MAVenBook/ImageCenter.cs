using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageCenter : MonoBehaviour
{
    public GameObject dummyCube1;
    public GameObject dummyCube2;

    void Update()
    {
        Transform iT_dummyCube1 = dummyCube1.GetComponent<Transform>();
        Transform iT_dummyCube2 = dummyCube2.GetComponent<Transform>();
        Vector3 dummyCube1_pos = iT_dummyCube1.transform.position;
        Vector3 dummyCube2_pos = iT_dummyCube2.transform.position;

        float center_obj_pos_x = (dummyCube1_pos.x + dummyCube2_pos.x) / 2;
        float center_obj_pos_y = (dummyCube1_pos.y + dummyCube2_pos.y) / 2;
        float center_obj_pos_z = (dummyCube1_pos.z + dummyCube2_pos.z) / 2;

        //Vector3 center_obj_pos = new Vector3(center_obj_pos_x, center_obj_pos_y , center_obj_pos_z);
        Vector3 center_obj_pos = new Vector3(center_obj_pos_x + 0.03f, dummyCube1_pos.y - 0.02f, center_obj_pos_z + 0.03f);
        this.transform.position = center_obj_pos;
    }
}
