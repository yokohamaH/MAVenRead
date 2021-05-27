using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;
using UnityEngine.UI;
using System;

public class StageOnOff : DefaultTrackableEventHandler
{
    public GameObject Trrain1;
    public GameObject Trrain2;

    void Awake()
    {
        Trrain2.SetActive(false);
    }

    protected override void OnTrackingFound ()
    {
        base.OnTrackingFound ();
        //Destroy(Trrain);
        Trrain1.SetActive(false);
        Trrain2.SetActive(true);
    }
}
