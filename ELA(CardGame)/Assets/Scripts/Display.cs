using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    public Card card;
    //public Text name;
    //public Text description;
    int health;
    public Text attack;
    public Text resistance;
    public Text hp;

    void Start()
    {
        //name.text = card.name;
        //description.text = card.description;
        attack.text = card.attack.ToString();
        health = card.health;
        resistance.text = card.resistance.ToString();
        attack.enabled = false;
        resistance.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        hp.text = health.ToString();
        if(Ready.ready.p2 == true)
        {
            attack.enabled = true;
            resistance.enabled = true;
        }
        else
        {
            attack.enabled = false;
            resistance.enabled = false;
        }

    }
}
