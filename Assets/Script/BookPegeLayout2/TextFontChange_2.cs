using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFontChange_2 : TextObject_2
{
    public Font Font;
    public void TextFontChange()
    {
        for (int i = 0; i < PagesText.Length; i++)
        {
            PagesText[i].GetComponent<Text>().font = Font;
        }
    }
}
