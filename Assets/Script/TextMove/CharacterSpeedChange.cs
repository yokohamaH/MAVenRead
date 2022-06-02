using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterSpeedChange : MonoBehaviour
{
    private GameObject[] OnCharacters;
    private OneCharacterOn Characterspeed;
    void Awake()
    {
        //Bのスクリプトを取得
        //OnCharacters = GameObject.FindGameObjectsWithTag("Character");
    }
    public void SpeedUp()
    {
        OnCharacters = GameObject.FindGameObjectsWithTag("Character");
        for (int i = 0; i < OnCharacters.Length; i++)
        {
            Characterspeed = OnCharacters[i].GetComponent<OneCharacterOn>(); 
            Characterspeed.speedPerCharacter -= 0.01f;
            
        }
    }
    public void SpeedDown()
    {
        OnCharacters = GameObject.FindGameObjectsWithTag("Character");
        for (int i = 0; i < OnCharacters.Length; i++)
        {
            Characterspeed = OnCharacters[i].GetComponent<OneCharacterOn>(); ;
            Characterspeed.speedPerCharacter += 0.01f;
        }
    }
}
