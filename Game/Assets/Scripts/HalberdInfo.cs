using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class HalberdInfo : MonoBehaviour
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

        if (Input.GetMouseButtonDown(0))
        {
            InfoText = GameObject.Find("TextBox").GetComponent<Text>();
            InfoText.text = ("This weapon is known as a halberd. It is a two-handed weapon that was used in the 14th and 15th centuries and is a combination of a spear and a battle axe.");

        }
    }
}
