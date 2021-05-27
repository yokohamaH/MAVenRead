using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrackBoad : MonoBehaviour
{
    public GameObject dummyCube1;
    public GameObject dummyCube2;


    void Update()
    {
        Transform iT_dummyCube1 = dummyCube1.GetComponent<Transform>();
        Transform iT_dummyCube2 = dummyCube2.GetComponent<Transform>();
        Vector3 dummyCube1_pos = iT_dummyCube1.transform.position;
        Vector3 dummyCube2_pos = iT_dummyCube2.transform.position;
        //RectTransform imageRect = this.GetComponent<RectTransform>();


        float scale_obj_pos_x = Mathf.Abs(dummyCube1_pos.x * 10f  - dummyCube2_pos.x* 10f) ;
        float scale_obj_pos_y = Mathf.Abs(dummyCube1_pos.y* 10f - dummyCube2_pos.y* 10f) ;
        float scale_obj_pos_z = Mathf.Abs(dummyCube1_pos.z* 10f - dummyCube2_pos.z* 10f) ;


        Vector3 root_obj_Scale = new Vector3(scale_obj_pos_x * 0.029f - 0.02f,  scale_obj_pos_z* 0.028f - 0.02f,  0.01f);

        this.transform.localScale = root_obj_Scale;
        //textRect.sizeDelta = new Vector3(scale_obj_pos_x, 0.1f, scale_obj_pos_y);


    }
}
