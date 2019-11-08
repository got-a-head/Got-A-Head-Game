using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class SwordInfo : MonoBehaviour
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
            InfoText.text = ("Most swords have four main parts: blade, guard, hilt and pommel.\n" +
            "The blade can be subdivided into different areas.  The sharp bit is the edge – some swords have a single sharp edge while others(e.g.claymore) are sharpened on both sides." +
            "The majority of swords taper to a tip, although some are straight until the very tip.Some swords are straight, while others(e.g.sabre, cutlass, scimitar, kukri) are curved. " +
            "The back is the part of the blade opposite the edge – a two-edged sword won’t have a back. " +
            "The flat is the side of the blade while the fuller(sometimes called a gutter or blood groove) runs down the length of it.  " +
            "Some heavier swords might have a ricasso, where the blade is unsharpened just before the guard(so the swordsman could use a second hand, if need be). " +
            "The tang is the part of the blade that is covered by the hilt(and sometimes goes as far as the pommel).\n" +
            "Guards are there, not unsurprisingly, to protect the hand.There are many designs of guards from a basic crossbar to a full ‘basket’.\n" +
            "The hilt is for holding the sword(the handle), while the pommel is at the end of the hilt is a heavy weight used to balance the sword to make it easier to hold.  It also stops your hand sliding off!");
        }
    }
}
