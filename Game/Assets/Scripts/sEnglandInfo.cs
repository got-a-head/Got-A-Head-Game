using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class sEnglandInfo : MonoBehaviour
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
            InfoText.text = ("“The Three Lions” were first used by King Richard I (The Lion Heart) 1189-1199, " +
                "More often than not the English Arms have been quartered with those of other countries, most notably France, then later Scotland and Ireland. " +
                "The three lions is used as the symbol on many English sporting teams, particularly its cricket and football teams, the latter use giving rise to the famous footballing song “Three Lions”.");
        }
    }
}
