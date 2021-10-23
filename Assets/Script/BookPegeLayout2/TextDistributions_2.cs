﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

//MAVenReadのダミー本の各ページにテキストを割り当てる
public class TextDistributions_2 : TextObject_2
{
    public static int BaceRow = 15;
    public static int BaceColumn = 12;
    int NumberTextSorte = 0;
    public void TextSort(int id)
    {
        string TextDatas = bookData[id];
        int NumberPages = TextDatas.Length / BaceRow / BaceColumn;
        int len = TextDatas.Length;
        NumberTextSorte = BaceRow * BaceColumn;

        string[] pageData = new string[50];
        PagesText[0].GetComponent<Text>().text = TextDatas;
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
        for (int i = BaceRow; i < NumberTextSorte + NumberTextSorte / BaceRow; i = i + BaceRow + 1)
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
        for (int i = 1; i < PagesText.Length; i++)
        {
            PagesText[i].GetComponent<Text>().text = pageData[i - 1];
        }
    }
}
