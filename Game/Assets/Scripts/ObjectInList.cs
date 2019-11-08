using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ObjectInList : MonoBehaviour
{
    public List<int> info = new List<int>();
    public int InfoNo;
    public int Count;
    public Text InfoText;
    public float Timer;

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
            var rand = new System.Random();
            do
            {
                InfoNo = (int)Math.Round((rand.NextDouble() * 3.0) + 0.5);
            } while (info.Contains(InfoNo));

            //First Info
            if (InfoNo == 1)
            {
                Timer = 5.0f;
                InfoText.text = ("Info 1");
                info.Add(InfoNo);
                Count = info.Count;
            }
            //Second Info
            if (InfoNo == 2)
            {
                Timer = 5.0f;
                InfoText.text = ("Info 2");
                info.Add(InfoNo);
                Count = info.Count;
            }
            //Third Info
            if (InfoNo == 3)
            {
                Timer = 5.0f;
                InfoText.text = ("Info 3");
                info.Add(InfoNo);
                Count = info.Count;
            }
            //Clears List when all info is showed

            if (Count == 3)
            {
                info.Clear();
                Debug.Log("List Cleared");
                Timer = 5.0f;
            }

        }
        
        //Timer Code
        if (InfoNo == 1)
        {
            Timer -= Time.deltaTime;
        }

        if (InfoNo == 2)
        {
            Timer -= Time.deltaTime;
        }

        if (InfoNo == 3)
        {
            Timer -= Time.deltaTime;
        }
        if (Timer <= 0.0)
        {
            TimerEnd();
        }
    }
    // Timer Ending Code
    void TimerEnd()
    {
        InfoText.text = ("");
        Timer = 0.0f;
        InfoNo = 0;
    }
}
