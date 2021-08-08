using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class TextChangeTag : TextObject
{
    void Start()
    {
        GameObject[] PageText = GameObject.FindGameObjectsWithTag("Cube");
        Debug.Log("Name:" + PageText[0].name);
    }
    /*    void Update()
        {
            MeshRenderer hanaMeshRenderer = hana.GetComponent<MeshRenderer>();
            MeshRenderer amenimoMeshRenderer = amenimo.GetComponent<MeshRenderer>();

            if (hanaMeshRenderer.isVisible)
            {
                TextSort(0);
            }
            else if (amenimoMeshRenderer.isVisible)
            {
                TextSort(2);
            }
        }
        private void TextSort(int id)
        {
            string TextDatas = bookData[id];
            int NumberPages = TextDatas.Length / 15 / 12;
            int len = TextDatas.Length;
            NumberTextSorte = 15 * 12;

            string[] pageData = new string[21];
            for (int i = 0; i < NumberPages + 1; i++)
            {
                if (i != NumberPages)
                {
                    pageData[i] = TextDatas.Substring(i * NumberTextSorte, NumberTextSorte);
                }
                else
                {
                    pageData[i] = TextDatas.Substring(i * NumberTextSorte, len - i * NumberTextSorte);
                }
            }

            for (int i = 15; i < NumberTextSorte + NumberTextSorte / 15; i += 16)
            {
                for (int j = 0; j < NumberPages; j++)
                {
                    pageData[j] = pageData[j].Insert(i, "\n");
                }
                if (i < pageData[NumberPages].Length)
                {
                    //Debug.Log(pageData[NumberPages].Length);
                    pageData[NumberPages] = pageData[NumberPages].Insert(i, "\n");
                }

            }

            Page1TargetText.text = pageData[0];
            Page2TargetText.text = pageData[1];
            Page3TargetText.text = pageData[2];
            Page4TargetText.text = pageData[3];
            Page5TargetText.text = pageData[4];
            Page6TargetText.text = pageData[5];
            Page7TargetText.text = pageData[6];
            Page8TargetText.text = pageData[7];
            Page9TargetText.text = pageData[8];
            Page10TargetText.text = pageData[9];
            Page11TargetText.text = pageData[10];
            Page12TargetText.text = pageData[11];
            Page13TargetText.text = pageData[12];
            Page14TargetText.text = pageData[13];
            Page15TargetText.text = pageData[14];
            Page16TargetText.text = pageData[15];
            Page17TargetText.text = pageData[16];
            Page18TargetText.text = pageData[17];
            Page19TargetText.text = pageData[18];
            Page20TargetText.text = pageData[19];

        }
        */
}
