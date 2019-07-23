using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ready : MonoBehaviour
{
    public GameObject ready1, ready2, reset1, reset2;
    public Text player1, player2;
    public static Ready ready;
    public bool p1, p2;
    void Start()
    {
        ready = this;
    }
    void Update()
    {
        if (P1.col1.p1collided == true)
            player1.enabled = false;
        else
            player1.enabled = true;
        if (P2.col2.p2collided == true)
            player2.enabled = false;
        else
            player2.enabled = true;

        if (p1 == true && p2 == true)
        {
            Fight();
            
        }
    }
    public void Fight()
    {
        StartCoroutine("Startfight");
    }
    public void P1_ready()
    {
        if (P1.col1.p1collided == true)
        {
            ready1.SetActive(false);
            reset1.SetActive(false);
            p1 = true;
        }
    }
    public void P2_ready()
    {
        if (p1 == true && P2.col2.p2collided == true)
        {
            p2 = true;
            ready2.SetActive(false);
            reset2.SetActive(false);
        }
    }
    public IEnumerator Startfight()
    {
        yield return new WaitForSeconds(2);
        Clamphealth.ch.Resetpos();
        Clamphealth2.ch.Resetpos();
        ready1.SetActive(true);
        reset1.SetActive(true);
        ready2.SetActive(true);
        reset2.SetActive(true);
        p1 = false;
        p2 = false;
    }
}
