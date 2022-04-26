using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextChangeScaru : MonoBehaviour
{
    public GameObject ImageTarget1;
    public GameObject ImageTarget2;


    void Update()
    {
        Transform TransformImageTarget1 = ImageTarget1.GetComponent<Transform>();
        Transform TransformImageTarget2 = ImageTarget2.GetComponent<Transform>();
        Vector3 ImageTarget1Pos = TransformImageTarget1.transform.position;
        Vector3 ImageTarget2Pos = TransformImageTarget2.transform.position;
        RectTransform TextRect = this.GetComponent<RectTransform>();


        float scale_obj_pos_x = Mathf.Abs(ImageTarget1Pos.x - ImageTarget2Pos.x) ;
        float scale_obj_pos_y = Mathf.Abs(ImageTarget1Pos.y* 0.002f - ImageTarget2Pos.y* 0.002f) ;
        float scale_obj_pos_z = Mathf.Abs(ImageTarget1Pos.z* 0.002f - ImageTarget2Pos.z* 0.002f) ;


        Vector3 root_obj_Scale = new Vector3(scale_obj_pos_z , scale_obj_pos_x*0.0028f-0.00027f,scale_obj_pos_y);//,

        this.transform.localScale = root_obj_Scale;
        //textRect.sizeDelta = new Vector3(scale_obj_pos_x, 0.1f, scale_obj_pos_y);


    }
}
