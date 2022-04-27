using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActveObject : MonoBehaviour
{
    // Start is called before the first frame update
    public void ActiveObject()
    {
        this.gameObject.SetActive(true);
    }
    
    public void DisActiveObject()
    {
        this.gameObject.SetActive(false);
    }
}
