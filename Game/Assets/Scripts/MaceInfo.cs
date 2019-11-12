using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class MaceInfo : MonoBehaviour
{
    public Text InfoTextM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Debug.Log("Right Clicked");
        }

        if (Input.GetMouseButtonDown(0))
        {
            InfoTextM = GameObject.Find("TextBox").GetComponent<Text>();
            InfoTextM.text = ("There are different definitions of mace. " +
                "In the game, it is a weapon that is a form of heavy club with a spiky head. " +
                "A ceremonial mace is a highly decorated staff of wood or metal used in civic ceremonies to represent an official’s authority. " +
                "Westminster, many universities and some town councils are examples of institutions that have a mace. " +
                "Mace is also the husk of the spice nutmeg and is used in cooking. It is used as a synonym for pepper spray, used as a deterrent against attack. " +
                "It is based on a brand name, although the original product was a form of tear gas rather than pepper spray.");
        }
    }
}
