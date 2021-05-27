using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;



public class TextSorte2 : MonoBehaviour
{
    public GameObject NumberPage;
    public GameObject TextData;
    public Text Page1TargetText;
    public Text Page2TargetText;
    public Text Page3TargetText;
    int NumberTextSorte = 0;

    void Update()
    {
        string NumberPages = NumberPage.GetComponent<Text>().text;
        string TextDatas = TextData.GetComponent<Text>().text;
        int x = Convert.ToInt32(NumberPages);
        int len = TextDatas.Length;
        NumberTextSorte = len / x;
        string page1 = TextDatas.Substring(0, NumberTextSorte);
        string page2 = TextDatas.Substring(NumberTextSorte+1, NumberTextSorte);
        string page3 = TextDatas.Substring(NumberTextSorte*2+1, NumberTextSorte);

        for(int i = 15; i < NumberTextSorte ; i+=15)
        {
            page1 = page1.Insert(i, "\n");
            page2 = page2.Insert(i, "\n");
            page3 = page3.Insert(i, "\n");
        }
        Page1TargetText.text = page1;
        Page2TargetText.text = page2;
        Page3TargetText.text = page3;
    }
}
