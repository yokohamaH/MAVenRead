using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using UnityEngine;
using TMPro;
using System;

public class TestPointer : MonoBehaviour
{
    
    public GameObject cube;
    public GameObject ARMaker;
    public GameObject BookText;
    private TextAnimationEye animationDatas;
    [SerializeField]
    private TextMeshProUGUI EysPointerPosituin;
    [SerializeField]
    private TextMeshProUGUI MakerPosition;

    void Start()
    {
        //目線を常に表示
        PointerUtils.SetGazePointerBehavior(PointerBehavior.AlwaysOn);
        
    }

    void Update()
    {
   
        TextColerChange();
        positionText();
    }

    private void positionText()
    {
        //オブジェクトを視線の位置に配置
        //cube.transform.position =CoreServices.InputSystem.EyeGazeProvider.HitPosition;
        cube.transform.position = new Vector3(CoreServices.InputSystem.EyeGazeProvider.HitPosition.x, CoreServices.InputSystem.EyeGazeProvider.HitPosition.y, CoreServices.InputSystem.EyeGazeProvider.HitPosition.z);

        //Debug.Log(CoreServices.InputSystem.EyeGazeProvider.HitPosition.x);
        //EysPointerPosituin.text = "x:" + CoreServices.InputSystem.EyeGazeProvider.HitPosition.x.ToString() + "\ny:" + CoreServices.InputSystem.EyeGazeProvider.HitPosition.y.ToString() + "\nz:" + CoreServices.InputSystem.EyeGazeProvider.HitPosition.z.ToString();
        
        try
        {
            MakerPosition.text = "x:" + (ARMaker.transform.position.x - CoreServices.InputSystem.EyeGazeProvider.HitPosition.x).ToString() + "\ny:" + (ARMaker.transform.position.y - CoreServices.InputSystem.EyeGazeProvider.HitPosition.y).ToString() + "\nz:" + (ARMaker.transform.position.z - CoreServices.InputSystem.EyeGazeProvider.HitPosition.z).ToString();
        }
        catch (Exception e)
        {
            MakerPosition.text = "NULL";
        }
    }

    private void CubeColerChange()
    {
        float TextPosition = ARMaker.transform.position.y - CoreServices.InputSystem.EyeGazeProvider.HitPosition.y;
        

        if (0.03 < TextPosition && TextPosition < 0.046)
        {
            cube.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (0.046 < TextPosition && TextPosition < 0.06)
        {
            cube.GetComponent<Renderer>().material.color = Color.black;
        }
        else if (0.06 < TextPosition && TextPosition < 0.074)
        {
            cube.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (0.074 < TextPosition && TextPosition < 0.088)
        {
            cube.GetComponent<Renderer>().material.color = Color.green;
        }
        else if(0.088 < TextPosition && TextPosition < 0.102)
        {
            cube.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }

    private void TextColerChange()
    {
        float TextPositionY = ARMaker.transform.position.y - CoreServices.InputSystem.EyeGazeProvider.HitPosition.y;
        float TextPositionX = ARMaker.transform.position.x - CoreServices.InputSystem.EyeGazeProvider.HitPosition.x;
        animationDatas = BookText.GetComponent<TextAnimationEye>();

        if (0.03 < TextPositionY && TextPositionY < 0.088)
        {
            animationDatas.time = TextPositionX * -100f * 1.5f;
            EysPointerPosituin.text = "1";
        }
        else
        {
            EysPointerPosituin.text = "0";
        }

        /*else if (0.046 < TextPositionY && TextPositionY < 0.06)
        {
            animationDatas.time = TextPositionZ * -100f * 5f + 21.5f;
            EysPointerPosituin.text = "2";
        }
        else if (0.06 < TextPositionY && TextPositionY < 0.074)
        {
            animationDatas.time = TextPositionZ * -100f * 5f   + 34.5f;
            EysPointerPosituin.text = "3";
        }
        else if (0.074 < TextPositionY && TextPositionY < 0.088)
        {
            animationDatas.time = TextPositionZ * -100f  * 5f + 46.5f;
            EysPointerPosituin.text = "4";
        }
        else if (0.088 < TextPositionY && TextPositionY < 0.102)
        {
            animationDatas.time = TextPositionZ * -100f * 5f + 57.5f;
            EysPointerPosituin.text = "5";
        }*/
       
    }
}

