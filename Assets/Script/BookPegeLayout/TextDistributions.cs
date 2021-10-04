using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

//MAVenReadのダミー本の各ページにテキストを割り当てる
public class TextDistributions : TextObject
{
    int NumberTextSorte = 0;
    public void TextSort(int id)
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
                pageData[NumberPages] = pageData[NumberPages].Insert(i, "\n");
            }

        }
        for (int i = 0; i < PagesText.Length; i++)
        {
            PagesText[i].GetComponent<Text>().text = pageData[i];
        }
    }
}
