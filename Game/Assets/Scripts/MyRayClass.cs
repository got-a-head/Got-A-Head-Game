using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class MyRayClass : MonoBehaviour
{
    public Text InfoText;
    public List<int> info = new List<int>();
    public int InfoNo;
    public int Count;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Creating the Ray
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //If Ray hits Sword
                if (hit.transform.name == "Sword(Clone)")
                {
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

                //If Ray Hits Scotland shield
                if (hit.transform.name == "Shield of Scotland(Clone)")
                {
                    InfoText.text = ("“The Lion Rampant,” seems to have first been used as the royal arms of Scotland by King William the Lion 1142-1214 and remains the royal arms of Scotland to this day." +
                " Queen Elizabeth who is Queen of the United Kingdom has these quartered on her royal coat of arms. " +
                "In the 1950s the campaigner for Scottish independence Wendy Wood had a long running argument with Scotland’s chief herald the Lord Lyon about who could use the coat of arms. " +
                "Wendy Wood proudly hung the Lion Rampant outside her house.  Her house happened to be on the tram line that the Lord Lyon took into work every morning. " +
                "He always made sure he sat on the side of the tram that didn’t give him a view of Wendy Wood’s house!  Less controversially it is used as the symbol on many Scottish sporting teams, particularly its football team.");
                }

                //If Ray hits Francer shield
                if (hit.transform.name == "Shield of France(Clone)")
                {
                    InfoText.text = ("In the UK we have the Prince of Wales as the title given to the heir to the throne." +
                " In France they have the Dauphin, or “Dolphin”?   Why?  Apparently there was a son  of  the Count of Albon, Vienne (just south of Lyon in France) called Guigues [who was nicknamed the dolphin. " +
                "He was called this in his father’s records in 1110.  He later became Count Guigues IV and the nickname stuck and was given to all his successors." +
                " A later Count Humbert II, who had no heir, sold his county to the French King Philip VI for the latter’s son on condition that he was known by the title Dauphin as did every heir to the French thrown afterwards." +
                " Hence the shield has the fleur de lys of France quartered with a dolphin.");
                }

                //If Ray hits England shield
                if (hit.transform.name == "Shield of England(Clone)")
                {
                    InfoText.text = ("“The Three Lions” were first used by King Richard I (The Lion Heart) 1189-1199, " +
                "More often than not the English Arms have been quartered with those of other countries, most notably France, then later Scotland and Ireland. " +
                "The three lions is used as the symbol on many English sporting teams, particularly its cricket and football teams, the latter use giving rise to the famous footballing song “Three Lions”.");
                }

                //If Ray hits Mace
                if (hit.transform.name == "Mace(Clone)")
                {
                    InfoText.text = ("There are different definitions of mace. " +
                "In the game, it is a weapon that is a form of heavy club with a spiky head. " +
                "A ceremonial mace is a highly decorated staff of wood or metal used in civic ceremonies to represent an official’s authority. " +
                "Westminster, many universities and some town councils are examples of institutions that have a mace. " +
                "Mace is also the husk of the spice nutmeg and is used in cooking. It is used as a synonym for pepper spray, used as a deterrent against attack. " +
                "It is based on a brand name, although the original product was a form of tear gas rather than pepper spray.");
                }

                //If Ray hits Halberd
                if (hit.transform.name == "Halberd(Clone)")
                {
                    InfoText.text = ("This weapon is known as a halberd. It is a two-handed weapon that was used in the 14th and 15th centuries and is a combination of a spear and a battle axe.");
                }

                //If Ray hits Crossbow
                if (hit.transform.name == "Cross Bow(Clone)")
                {
                    InfoText.text = ("There are different types of bows, depending on when they were made and where.\n " +
                "Longbow – a tall bow that is roughly the size of the archer using it.The English Longbow was used in Mediaeval times to great success.\n" +
                "Crossbow – the earliest crossbows were used in ancient China \n" +
                "Compound bow – Mongol warriors");
                }

                //If Ray hits Axe
                if (hit.transform.name == "Axe(Clone)")
                {
                    InfoText.text = ("Parts of the axe \nThe eye \nThe blade or cutting edge \n" +
                "Axeblade or bit\n" +
                "This lip or lug is a way of securing the axe head to the handle\n" +
                "Handle\n" +
                "The knob at the end is to stop the axe slipping out of the user’s hands\n" +
                "Poll or butt\n" +
                "Axe head");
                }

                //If Ray hits Armour
                if (hit.transform.name == "Suit of Armour(Clone)")
                {
                    InfoText.text = ("Suits of armour conjure up knights of old, but did you know there were some famous women who wore armour?  Joan of Arc, " +
                "also known as the ‘Maid of Orléans’, is a French heroine for her actions during the Hundred Years War. She was later considered a martyr and was made a saint in 1920.  " +
                "Elizabeth I was also seen in armour at Tilbury, when she was encouraging her troops who were about to fight the Spanish Armada.");
                }

                //If Ray hits Arrows
                if (hit.transform.name == "Arrows and Quiver(Clone)")
                {
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
                        //Debug.Log("List Cleared");
                    }
                }
            }
        }
            
    }
}
