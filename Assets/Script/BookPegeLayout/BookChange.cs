using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

//MAVenReadのダミー本の各ページにテキストを割り当てる
public class BookChange : TextObject
{
    int NumberTextSorte = 0;
    string TextDatas = null;
    public void BookChang(int id)
    {
        TextDatas = bookData[id];
    }

    public void TextSote(int Row, int Column)
    {
        int NumberPages = TextDatas.Length / Row / Column;
        int len = TextDatas.Length;
        NumberTextSorte = Row * Column;

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

        for (int i = Row; i < NumberTextSorte + NumberTextSorte / Row; i = i + Row + 1)
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
