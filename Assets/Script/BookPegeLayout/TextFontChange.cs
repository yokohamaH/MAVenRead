using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFontChange : TextObject
{
    public Font Font;
    public void TextFontChangeGomarice()
    {
        for (int i = 0; i < PagesText.Length; i++)
        {
            PagesText[i].GetComponent<Text>().font = Font;
        }
    }
}
