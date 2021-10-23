using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFontSizeChange_2 : TextObject_2
{
    public void TextFontSizeChange(int size)
    {
        for (int i = 0; i < PagesText.Length; i++)
        {
            PagesText[i].GetComponent<Text>().fontSize = size;
        }
    }
}
