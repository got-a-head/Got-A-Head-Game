using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class sFranceInfo : MonoBehaviour
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
            InfoText.text = ("In the UK we have the Prince of Wales as the title given to the heir to the throne." +
                " In France they have the Dauphin, or “Dolphin”?   Why?  Apparently there was a son  of  the Count of Albon, Vienne (just south of Lyon in France) called Guigues [who was nicknamed the dolphin. " +
                "He was called this in his father’s records in 1110.  He later became Count Guigues IV and the nickname stuck and was given to all his successors." +
                " A later Count Humbert II, who had no heir, sold his county to the French King Philip VI for the latter’s son on condition that he was known by the title Dauphin as did every heir to the French thrown afterwards." +
                " Hence the shield has the fleur de lys of France quartered with a dolphin.");
        }
    }
}
