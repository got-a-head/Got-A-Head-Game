using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class sScotlandInfo : MonoBehaviour
{
    public Text InfoTextSs;

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
            InfoTextSs = GameObject.Find("TextBox").GetComponent<Text>();
            InfoTextSs.text = ("“The Lion Rampant,” seems to have first been used as the royal arms of Scotland by King William the Lion 1142-1214 and remains the royal arms of Scotland to this day." +
                " Queen Elizabeth who is Queen of the United Kingdom has these quartered on her royal coat of arms. " +
                "In the 1950s the campaigner for Scottish independence Wendy Wood had a long running argument with Scotland’s chief herald the Lord Lyon about who could use the coat of arms. " +
                "Wendy Wood proudly hung the Lion Rampant outside her house.  Her house happened to be on the tram line that the Lord Lyon took into work every morning. " +
                "He always made sure he sat on the side of the tram that didn’t give him a view of Wendy Wood’s house!  Less controversially it is used as the symbol on many Scottish sporting teams, particularly its football team.");
        }
    }
}
