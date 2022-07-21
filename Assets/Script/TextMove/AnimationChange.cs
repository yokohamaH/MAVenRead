using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class AnimationChange : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject[] MoveText;
    private TextMeshProGeometryAnimation animationDatas;
    private TMPro.TMP_Text ButtonText;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    public GameObject Button5;
    public GameObject Button6;
    public GameObject DelayButton;
    private TMPro.TMP_Text DelayButtonText;
    private string[] ButtonTextsON = new string[] { "Position\nON", "PositionNoise\nON" , "Scale\nON", "Rotation\nON", "ScaleNoise\nON", "Typewriter\nON","Delay\nON" };
    private string[] ButtonTextsOFF = new string[] { "Position\nOFF","PositionNoise\nOFF", "Scale\nOFF", "Rotation\nOFF", "ScaleNoise\nOFF", "Typewriter\nOFF","Delay\nOFF"};

    public void PositionOn()
    {
        MoveText = GameObject.FindGameObjectsWithTag("MoveText");
        DelayButtonText = DelayButton.GetComponent<TMPro.TMP_Text>();
        for (int i = 0; i < MoveText.Length; i++)
        {
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().enabled = true;
            MoveText[i].GetComponent<OneCharacterOn>().enabled = false;
            animationDatas = MoveText[i].GetComponent<TextMeshProGeometryAnimator>().animationData;
            animationDatas.position.use = true;
            animationDatas.positionNoise.use = false;
            animationDatas.scale.use = false;
            animationDatas.rotation.use = false;
            animationDatas.scaleNoise.use = false;
            animationDatas.useMaxVisibleCharacter = true;
            animationDatas.useMaxVisibleCharacter = false;
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().Refresh(true);
        }
        if (animationDatas.position.wave == 0f)
        {
            DelayButtonText.text = ButtonTextsOFF[6];
        }
        else
        {
            DelayButtonText.text = ButtonTextsON[6];
        }
        ButtonTextChange(0);

    }
    public void positionNoiseOn()
    {
        MoveText = GameObject.FindGameObjectsWithTag("MoveText");
        DelayButtonText = DelayButton.GetComponent<TMPro.TMP_Text>();
        for (int i = 0; i < MoveText.Length; i++)
        {
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().enabled = true;
            MoveText[i].GetComponent<OneCharacterOn>().enabled = false;
            animationDatas = MoveText[i].GetComponent<TextMeshProGeometryAnimator>().animationData;
            animationDatas.position.use = false;
            animationDatas.positionNoise.use = true;
            animationDatas.scale.use = false;
            animationDatas.rotation.use = false;
            animationDatas.scaleNoise.use = false;
            animationDatas.useMaxVisibleCharacter = true;
            animationDatas.useMaxVisibleCharacter = false;
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().Refresh(true);
        }
        if (animationDatas.positionNoise.wave == 0f)
        {
            DelayButtonText.text = ButtonTextsOFF[6];
        }
        else
        {
            DelayButtonText.text = ButtonTextsON[6];
        }
        ButtonTextChange(1);
    }
    public void ScaleOn()
    {
        MoveText = GameObject.FindGameObjectsWithTag("MoveText");
        DelayButtonText = DelayButton.GetComponent<TMPro.TMP_Text>();
        for (int i = 0; i < MoveText.Length; i++)
        {
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().enabled = true;
            MoveText[i].GetComponent<OneCharacterOn>().enabled = false;
            animationDatas = MoveText[i].GetComponent<TextMeshProGeometryAnimator>().animationData;
            animationDatas.position.use = false;
            animationDatas.positionNoise.use = false;
            animationDatas.scale.use = true;
            animationDatas.rotation.use = false;
            animationDatas.scaleNoise.use = false;
            animationDatas.useMaxVisibleCharacter = true;
            animationDatas.useMaxVisibleCharacter = false;
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().Refresh(true);
        }
        if (animationDatas.scale.wave == 0f)
        {
            DelayButtonText.text = ButtonTextsOFF[6];
        }
        else
        {
            DelayButtonText.text = ButtonTextsON[6];
        }
        ButtonTextChange(2);
    }
    public void RotationOn()
    {
        MoveText = GameObject.FindGameObjectsWithTag("MoveText");
        DelayButtonText = DelayButton.GetComponent<TMPro.TMP_Text>();
        for (int i = 0; i < MoveText.Length; i++)
        {
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().enabled = true;
            MoveText[i].GetComponent<OneCharacterOn>().enabled = false;
            animationDatas = MoveText[i].GetComponent<TextMeshProGeometryAnimator>().animationData;
            animationDatas.position.use = false;
            animationDatas.positionNoise.use = false;
            animationDatas.scale.use = false;
            animationDatas.rotation.use = true;
            animationDatas.scaleNoise.use = false;
            animationDatas.useMaxVisibleCharacter = true;
            animationDatas.useMaxVisibleCharacter = false;
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().Refresh(true);
        }
        if (animationDatas.rotation.wave == 0f)
        {
            DelayButtonText.text = ButtonTextsOFF[6];
        }
        else
        {
            DelayButtonText.text = ButtonTextsON[6];
        }
        ButtonTextChange(3);
    }
    public void ScaleNoiseOn()
    {
        MoveText = GameObject.FindGameObjectsWithTag("MoveText");
        DelayButtonText = DelayButton.GetComponent<TMPro.TMP_Text>();
        for (int i = 0; i < MoveText.Length; i++)
        {
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().enabled = true;
            MoveText[i].GetComponent<OneCharacterOn>().enabled = false;
            animationDatas = MoveText[i].GetComponent<TextMeshProGeometryAnimator>().animationData;
            animationDatas.position.use = false;
            animationDatas.positionNoise.use = false;
            animationDatas.scale.use = false;
            animationDatas.rotation.use = false;
            animationDatas.scaleNoise.use = true;
            animationDatas.useMaxVisibleCharacter = true;
            animationDatas.useMaxVisibleCharacter = false;
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().Refresh(true);
        }
        if(animationDatas.scaleNoise.wave == 0f)
        {
            DelayButtonText.text = ButtonTextsOFF[6];
        }
        else
        {
            DelayButtonText.text = ButtonTextsON[6];
        }
        ButtonTextChange(4);
    }
    public void TypewriterOn()
    {
        MoveText = GameObject.FindGameObjectsWithTag("MoveText");
        for (int i = 0; i < MoveText.Length; i++)
        {
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().enabled = false;
            MoveText[i].GetComponent<OneCharacterOn>().enabled = true;
        }
        
        ButtonTextChange(5);
    }

    public void DelayOnOff()
    {
        MoveText = GameObject.FindGameObjectsWithTag("MoveText");
        DelayButtonText = DelayButton.GetComponent<TMPro.TMP_Text>();
        for (int i = 0; i < MoveText.Length; i++)
        {
            animationDatas = MoveText[i].GetComponent<TextMeshProGeometryAnimator>().animationData;
            if (animationDatas.position.use)
            {
                if (animationDatas.position.wave == 0f)
                {
                    animationDatas.position.wave = 0.35f;
                    //animationDatas.position.curve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(0.5f, 30f), new Keyframe(1f, 0f));
                    DelayButtonText.text = ButtonTextsON[6];
                }
                else
                {
                    animationDatas.position.wave = 0f;
                    //animationDatas.position.curve = AnimationCurve.Linear(timeStart: 0f, valueStart: 0f, timeEnd: 1f, valueEnd: 1f);
                    DelayButtonText.text = ButtonTextsOFF[6];
                }
            }
            else if (animationDatas.rotation.use)
            {
                if (animationDatas.rotation.wave == 0f)
                {
                    animationDatas.rotation.wave = 0.35f;
                    //animationDatas.rotation.curve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(0.5f, 1f), new Keyframe(1f, 0f));
                    DelayButtonText.text = ButtonTextsON[6];
                }
                else
                {
                    animationDatas.rotation.wave = 0f;
                    //animationDatas.rotation.curve = AnimationCurve.Linear(timeStart: 0f, valueStart: 0f, timeEnd: 1f, valueEnd: 1f);
                    DelayButtonText.text = ButtonTextsOFF[6];
                }
            }
            else if (animationDatas.scale.use)
            {
                if (animationDatas.scale.wave == 0f)
                {
                    animationDatas.scale.wave = 0.35f;
                    //animationDatas.scale.curve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(0.5f, 1f), new Keyframe(1f, 0f));
                    DelayButtonText.text = ButtonTextsON[6];
                }
                else
                {
                    animationDatas.scale.wave = 0f;
                    //animationDatas.scale.curve = AnimationCurve.Linear(timeStart: 0f, valueStart: 0f, timeEnd: 1f, valueEnd: 1f);
                    DelayButtonText.text = ButtonTextsOFF[6];
                }
            }
            else if (animationDatas.positionNoise.use)
            {
                if (animationDatas.positionNoise.wave == 0f)
                {
                    animationDatas.positionNoise.wave = 0.35f;
                    animationDatas.positionNoise.curve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(0.5f, 30f), new Keyframe(1f, 0f)); 
                    DelayButtonText.text = ButtonTextsON[6];
                }
                else
                {
                    animationDatas.positionNoise.wave = 0f;
                    animationDatas.positionNoise.curve = AnimationCurve.Constant(timeStart: 0f, timeEnd: 1f, value: 30f);
                    DelayButtonText.text = ButtonTextsOFF[6];
                }
            }
            else if (animationDatas.scaleNoise.use)
            {
                if (animationDatas.scaleNoise.wave == 0f)
                {
                    animationDatas.scaleNoise.wave = 0.35f;
                    animationDatas.scaleNoise.curve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(0.5f, 1f), new Keyframe(1f, 0f));
                    DelayButtonText.text = ButtonTextsON[6];
                }
                else
                {
                    animationDatas.scaleNoise.wave = 0f;
                    animationDatas.scaleNoise.curve = AnimationCurve.Constant(timeStart: 0f, timeEnd: 1f, value: 1f);
                    DelayButtonText.text = ButtonTextsOFF[6];
                }
            }
            MoveText[i].GetComponent<TextMeshProGeometryAnimator>().Refresh(true);
        }

    }

    private void ButtonTextChange(int Button)
    {
        GameObject[] PositionButtonTextObject = new GameObject[6] { Button1,Button2,Button3,Button4,Button5,Button6};
        for (int i = 0; i < 6; i++)
        {
            ButtonText = PositionButtonTextObject[i].GetComponent<TMPro.TMP_Text>();
            ButtonText.text = ButtonTextsOFF[i];
        }
        ButtonText = PositionButtonTextObject[Button].GetComponent<TMPro.TMP_Text>();
        ButtonText.text = ButtonTextsON[Button];
    }
}
