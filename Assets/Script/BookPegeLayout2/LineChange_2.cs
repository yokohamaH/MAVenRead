using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;


//MAVenReadのダミー本の各ページにテキストを割り当てる
public class LineChange_2 : MonoBehaviour
{
    protected GameObject[] PagesText = null;

    public static int BaceRow = 12;
    public static int BaceColumn = 13;
    public void TextSote(int line)
    {
        int NumberTextSorte = 0;
        string TextDatas = null;
        PagesText = GameObject.FindGameObjectsWithTag("Text");
        TextDatas = PagesText[0].GetComponent<Text>().text;
        int Row = line / 100 % 100;
        int Column = line % 100;

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
        for (int i = 1; i < PagesText.Length; i++)
        {
            PagesText[i].GetComponent<Text>().text = pageData[i - 1];
        }
    }
    public void TextSoteLine(int x)
    {
        int NumberTextSorte = 0;
        string TextDatas = null;
        PagesText = GameObject.FindGameObjectsWithTag("Text");
        TextDatas = PagesText[0].GetComponent<Text>().text;
        switch (x)
        {
            case 0:
                BaceRow = BaceRow + 1;
                break;
            case 1:
                BaceRow = BaceRow - 1;
                break;
            case 2:
                BaceColumn = BaceColumn + 1;
                break;
            case 3:
                BaceColumn = BaceColumn - 1;
                break;
        }
        int NumberPages = TextDatas.Length / BaceRow / BaceColumn;
        int len = TextDatas.Length;
        NumberTextSorte = BaceRow * BaceColumn;

        string[] pageData = new string[100];
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
    public void TextSoteRowPull()
    {
        int NumberTextSorte = 0;
        string TextDatas = null;
        PagesText = GameObject.FindGameObjectsWithTag("Text");
        TextDatas = PagesText[0].GetComponent<Text>().text;
        if (BaceRow > 1)
        {
            BaceRow = BaceRow - 1;
        }

        int NumberPages = TextDatas.Length / BaceRow / BaceColumn;
        int len = TextDatas.Length;
        NumberTextSorte = BaceRow * BaceColumn;

        string[] pageData = new string[100];

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
    public void TextSoteColumnAdd()
    {
        int NumberTextSorte = 0;
        string TextDatas = null;
        PagesText = GameObject.FindGameObjectsWithTag("Text");
        TextDatas = PagesText[0].GetComponent<Text>().text;
        BaceColumn = BaceColumn + 1;

        int NumberPages = TextDatas.Length / BaceRow / BaceColumn;
        int len = TextDatas.Length;
        NumberTextSorte = BaceRow * BaceColumn;

        string[] pageData = new string[100];
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
    public void TextSoteColumnPull()
    {
        int NumberTextSorte = 0;
        string TextDatas = null;
        PagesText = GameObject.FindGameObjectsWithTag("Text");
        TextDatas = PagesText[0].GetComponent<Text>().text;
        BaceColumn = BaceColumn - 1;

        int NumberPages = TextDatas.Length / BaceRow / BaceColumn;
        int len = TextDatas.Length;
        NumberTextSorte = BaceRow * BaceColumn;

        string[] pageData = new string[100];
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
