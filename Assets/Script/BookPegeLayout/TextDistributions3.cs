using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class TextDistributions3 : TextObject
{
    public GameObject hana;
    public GameObject amenimo;
    int NumberTextSorte = 0;

    void Update()
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
        for (int i = 0; i < PagesText.Length; i++)
        {
            PagesText[i].GetComponent<Text>().text = pageData[i];
        }
    }
}
