using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

//テキストの色を変更する
public class TextColorChange : TextObject
{
    public GameObject SoldierScore;
    public void ChangeYellow()
    {
        for (int i = 0; i < PagesText.Length; i++)
        {
            Text SoldierScoreText = PagesText[i].GetComponent<Text>();
            SoldierScoreText.color = Color.yellow;
        }
    }
    public void ChangeRed()
    {
        for (int i = 0; i < PagesText.Length; i++)
        {
            Text SoldierScoreText = PagesText[i].GetComponent<Text>();
            SoldierScoreText.color = Color.yellow;
        }
    }
    public void ChangeBlack()
    {
        for (int i = 0; i < PagesText.Length; i++)
        {
            Text SoldierScoreText = PagesText[i].GetComponent<Text>();
            SoldierScoreText.color = Color.yellow;
        }
    }
}
