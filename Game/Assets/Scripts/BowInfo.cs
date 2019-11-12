using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class BowInfo : MonoBehaviour
{
    public Text InfoTextB;

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
        //Left Click
        if (Input.GetMouseButtonDown(0))
        {
            InfoTextB = GameObject.Find("TextBox").GetComponent<Text>();
            InfoTextB.text = ("There are different types of bows, depending on when they were made and where.\n " +
                "Longbow – a tall bow that is roughly the size of the archer using it.The English Longbow was used in Mediaeval times to great success.\n" +
                "Crossbow – the earliest crossbows were used in ancient China \n" +
                "Compound bow – Mongol warriors");
        }
    }
}
