using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{

    public Text booktext;
    void StartUp()
    {
        //booktext.text = "わたくしといふ現象は\n仮定された有機交流電燈の\nひとつの青い照明です\n（あらゆる透明な幽霊の複合体）\n風景やみんなといつしよに\nせはしくせはしく明滅しながら\nいかにもたしかにともりつづける\n因果交流電燈の\nひとつの青い照明です\n（ひかりはたもちその電燈は失はれ）";
    }
    // Update is called once per frame
    void Update()
    {
        booktext.text = "わたくしといふ現象は\n仮定された有機交流電燈の\nひとつの青い照明です\n（あらゆる透明な幽霊の複合体）\n風景やみんなといつしよに\nせはしくせはしく明滅しながら\nいかにもたしかにともりつづける\n因果交流電燈の\nひとつの青い照明です\n（ひかりはたもちその電燈は失はれ）";
    }
}
