using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Sword;
    public GameObject Armour;
    public GameObject Halberd;
    public GameObject sScotland;
    public GameObject sFrance;
    public GameObject sEngland;
    public GameObject Axe;
    public GameObject Mace;
    public GameObject Pike;
    public GameObject Crossbow;
    public GameObject Arrows;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Sword, new Vector3(29, 13, 5), Quaternion.identity);
        Instantiate(Sword, new Vector3(30, 13, 5), Quaternion.identity);
        Instantiate(Sword, new Vector3(31, 13, 5), Quaternion.identity);
        Instantiate(Armour, new Vector3(27, 13, 5), Quaternion.identity);
        Instantiate(Halberd, new Vector3(25, 13, 5), Quaternion.identity);
        Instantiate(sScotland, new Vector3(24, 12, 5), Quaternion.identity);
        Instantiate(sFrance, new Vector3(23, 12, 5), Quaternion.identity);
        Instantiate(sEngland, new Vector3(22, 12, 5), Quaternion.identity);
        Instantiate(Axe, new Vector3(22, 15, 5), Quaternion.identity);
        Instantiate(Mace, new Vector3(24, 15, 5), Quaternion.identity);
        Instantiate(Pike, new Vector3(32, 13, 5), Quaternion.identity);
        Instantiate(Arrows, new Vector3(34, 16, 5), Quaternion.identity);
        Instantiate(Arrows, new Vector3(37, 16, 5), Quaternion.identity);
        Instantiate(Crossbow, new Vector3(34, 13, 5), Quaternion.identity);
        Instantiate(Crossbow, new Vector3(37, 13, 5), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
