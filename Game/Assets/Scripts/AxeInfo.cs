using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class AxeInfo : MonoBehaviour
{
    public Text InfoText;

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
            InfoText = GameObject.Find("TextBox").GetComponent<Text>();
            InfoText.text = ("Parts of the axe \nThe eye \nThe blade or cutting edge \n" +
                "Axeblade or bit\n" +
                "This lip or lug is a way of securing the axe head to the handle\n" +
                "Handle\n" +
                "The knob at the end is to stop the axe slipping out of the user’s hands\n" +
                "Poll or butt\n" +
                "Axe head");
        }

    }
}
