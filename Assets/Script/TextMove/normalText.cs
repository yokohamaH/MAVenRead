using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalText : MonoBehaviour
{

    private bool normal = false;
    private GameObject[] OnCharacters;
    private OneCharacterOn Characterspeed;
    private TMPro.TMP_Text text = default;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
        }
    }
}
