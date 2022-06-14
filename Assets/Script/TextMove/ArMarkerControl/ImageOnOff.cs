using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ImageOnOff : MonoBehaviour
{
    public GameObject marker1;
    public GameObject marker2;
    public GameObject BookText;

    // Update is called once per frame
    void Update()
    {
        MeshRenderer marker1_meshRenderer = marker1.GetComponent<MeshRenderer>();
        MeshRenderer marker2_meshRenderer = marker2.GetComponent<MeshRenderer>();
        Text BookTextComponent = BookText.GetComponent<Text>();

        if (marker1_meshRenderer.isVisible && marker2_meshRenderer.isVisible)
        {
            BookTextComponent.enabled = true;
        }
        else
        {
            BookTextComponent.enabled = false;
        }
    }
}
