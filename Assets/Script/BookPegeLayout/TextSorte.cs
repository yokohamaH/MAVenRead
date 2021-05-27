using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;



public class TextSorte : MonoBehaviour
{
    public GameObject NumberPage;
    public GameObject TextData;
    public GameObject FrontTarget;
    public Text Page1TargetText;
    int NumberTextSorte = 0;

    void Update()
    {
        MeshRenderer FrontTargetMeshRenderer = FrontTarget.GetComponent<MeshRenderer>();
         if (FrontTargetMeshRenderer.isVisible)
        {
            string NumberPages = NumberPage.GetComponent<Text>().text;
            string TextDatas = TextData.GetComponent<Text>().text;
            int x = Convert.ToInt32(NumberPages);
            int len = TextDatas.Length;
            NumberTextSorte = len / x;
            string page1 = TextDatas.Substring(0, NumberTextSorte);
            string page2 = TextDatas.Substring(NumberTextSorte+1, NumberTextSorte);
            string page3 = TextDatas.Substring(NumberTextSorte*2+1, NumberTextSorte);

            for(int i = 15; i < NumberTextSorte + NumberTextSorte / 15  ; i+= 16)
            {
                page1 = page1.Insert(i, "\n");
                page2 = page2.Insert(i, "\n");
                page3 = page3.Insert(i, "\n");
            }

            Page1TargetText.text = page1;
            Debug.Log(NumberTextSorte);
        }

    }

}
