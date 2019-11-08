using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class ArrowsInfo : MonoBehaviour
{
    public List<int> info = new List<int>();
    public int InfoNo;
    public int Count;
    public Text InfoText;

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
        //Left Click
        if (Input.GetMouseButtonDown(0))
        {
            InfoText = GameObject.Find("TextBox").GetComponent<Text>();
            var rand = new System.Random();
            do
            {
                InfoNo = (int)Math.Round((rand.NextDouble() * 2.0) + 0.5);
            } while (info.Contains(InfoNo));

            if (InfoNo == 1)
            {
                InfoText.text = ("A fletcher made arrows.  This is because he attached fletching or feathers to the arrow shaft. " +
                    "Traditionally, these feathers came from hens and cocks. Each fletch (most arrows had three or four) would be cut to shape. " +
                    "A good arrow was one that had well-matched fletching as it would be more likely to fly ‘true’ to the target.");
                info.Add(InfoNo);
                Count = info.Count;
            }

            if (InfoNo == 2)
            {
                InfoText.text = ("The person who made arrows was called a fletcher. " +
                    "Over time John ‘the fletcher’ would become simply John Fletcher. " +
                    "There are many other jobs that are now common English surnames:Smith – most common, as there were lots of different types of smith;\n" +
                    "Cooper – made barrels.\n" +
                    "Archer – the bowman(also used as a surname) who would use the arrows. \n" +
                    "Farrier – a type of blacksmith who specialises in shoeing horses – he would usually go to the horse, where a normal blacksmith would stay at his forge. \n" +
                    "Farmer – someone who would grow crops or tend animals to feed the population. \n" +
                    "Butcher – a person who would cut up the animals and sell the parts(e.g.chops, steak etc.). \n" +
                    "Baker – someone who made bread. \n" +
                    "Miller – a person who ground the corn to make the bread the baker would use. \n" +
                    "Brewer – someone who would brew beer. \n" +
                    "Cook – named for the job at the lord’s manor. \n" +
                    "Carpenter – a person who would work with wood, making tools, furniture or parts of a building Joiner – a similar type of craftsman to a carpenter. \n" +
                    "Can you think of others ?");
                info.Add(InfoNo);
                Count = info.Count;
            }
            if (Count == 2)
            {
                info.Clear();
                Debug.Log("List Cleared");
            }
        }
    }
}
