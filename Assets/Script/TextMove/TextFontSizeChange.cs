using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextFontSizeChange : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject[] MoveText;
    private GameObject[] OneCharacterText;
    private TMPro.TMP_Text TMPfont;
    public void FontSizeUp()
    {
        MoveText = GameObject.FindGameObjectsWithTag("MoveText");
        OneCharacterText = GameObject.FindGameObjectsWithTag("Character");
        for (int i = 0; i < MoveText.Length; i++)
        {
            TMPfont = MoveText[i].GetComponent<TMPro.TMP_Text>();
            TMPfont.fontSize += 10;
        }
        for (int i = 0; i < OneCharacterText.Length; i++)
        {
            TMPfont = OneCharacterText[i].GetComponent<TMPro.TMP_Text>();
            TMPfont.fontSize += 10;
        }
    }
    public void FontSizeDown()
    {
        MoveText = GameObject.FindGameObjectsWithTag("MoveText");
        OneCharacterText = GameObject.FindGameObjectsWithTag("Character");
        for (int i = 0; i < MoveText.Length; i++)
        {
            TMPfont = MoveText[i].GetComponent<TMPro.TMP_Text>();
            TMPfont.fontSize -= 10f;
        }
        for (int i = 0; i < OneCharacterText.Length; i++)
        {
            TMPfont = OneCharacterText[i].GetComponent<TMPro.TMP_Text>();
            TMPfont.fontSize -= 10;
        }
    }
}
