using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ArmourInfo : MonoBehaviour
{
    public Text InfoTextAr;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Right Clicked");
        }

        if (Input.GetMouseButtonDown(0))
        {
            InfoTextAr = GameObject.Find("TextBox").GetComponent<Text>();
            InfoTextAr.text = ("Suits of armour conjure up knights of old, but did you know there were some famous women who wore armour?  Joan of Arc, " +
                "also known as the ‘Maid of Orléans’, is a French heroine for her actions during the Hundred Years War. She was later considered a martyr and was made a saint in 1920.  " +
                "Elizabeth I was also seen in armour at Tilbury, when she was encouraging her troops who were about to fight the Spanish Armada.  ");
        }
    }
}
