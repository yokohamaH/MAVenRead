using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twoMarker : MonoBehaviour
{
    public void subMarkerOff()
    {
        this.gameObject.SetActive(false);
    }
    public void subMarkerOn()
    {
        this.gameObject.SetActive(true);
    }
}
