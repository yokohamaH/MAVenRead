using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControru : MonoBehaviour
{
    public GameObject ARCamera;

    // Update is called once per frame
    void Update()
    {
        Transform MainCameraTransform = this.transform;
        Transform ARCameraTransform = ARCamera.GetComponent<Transform>();
        Vector3 ARCamerPos = ARCameraTransform.position;
        var ARCameraRot = ARCameraTransform.rotation;

        MainCameraTransform.position = ARCamerPos;
        MainCameraTransform.rotation = ARCameraRot;
    }
}
