using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class normalText : MonoBehaviour
{

    private bool normal = false;
    private GameObject[] OnCharacters;
    private OneCharacterOn Characterspeed;
    private TMPro.TMP_Text text = default;
    private TMPro.TMP_Text ButtonText;
    public GameObject ButtontextObject;
    

    // Start is called before the first frame update

    public void normalChange()
    {
        OnCharacters = GameObject.FindGameObjectsWithTag("Character");

        if (normal)
        {
            for (int i = 0; i < OnCharacters.Length; i++)
            {
                OnCharacters[i].GetComponent<OneCharacterOn>().enabled = true;
            }
            normal = false;
            ButtonText = ButtontextObject.GetComponent<TMPro.TMP_Text>();
            ButtonText.text = "RSVP";
        }
        else
        {
            for (int i = 0; i < OnCharacters.Length; i++)
            {
                text = OnCharacters[i].GetComponent<TMPro.TMP_Text>();
                OnCharacters[i].GetComponent<OneCharacterOn>().enabled = false;
                this.text.maxVisibleCharacters = 500;
            }
            normal = true;
            ButtonText = ButtontextObject.GetComponent<TMPro.TMP_Text>();
            ButtonText.text = "nomal";
        }
    }
}
