using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class TextColorChange : MonoBehaviour
{
    public GameObject SoldierScore;
    public void ChangeYellow()
    {
        Text SoldierScoreText = SoldierScore.GetComponent<Text>();

        SoldierScoreText.color = Color.yellow;

    }
    public void ChangeRed()
    {
        Text SoldierScoreText = SoldierScore.GetComponent<Text>();

        SoldierScoreText.color = Color.red;

    }
    public void ChangeBlack()
    {
        Text SoldierScoreText = SoldierScore.GetComponent<Text>();

        SoldierScoreText.color = Color.black;

    }

}
