using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class digitalOnOff : MonoBehaviour
{
    public GameObject DigitalText;
    public void PageOnOff()
    {
        if (DigitalText.activeSelf)
        {
            DigitalText.SetActive(false);
        }
        else
        {
            DigitalText.SetActive(true);
        }
    }
}
