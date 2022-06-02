using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NowSpeed : MonoBehaviour
{
    public GameObject OnCharacters;
    
    public TextMeshProUGUI nowSpped;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        SpeedText();
    }
    public void SpeedText()
    {
        OneCharacterOn Characterspeed;
        Characterspeed = OnCharacters.GetComponent<OneCharacterOn>();
        nowSpped.text = Characterspeed.speedPerCharacter.ToString();
    }
}
