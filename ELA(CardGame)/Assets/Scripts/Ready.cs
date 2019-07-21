using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ready : MonoBehaviour
{
    bool p1, p2;
    void Start()
    {
        
    }
    void Update()
    {
        if(p1 == true && p2 == true)
        {
            Fight();
            p1 = false;
            p2 = false;
        }
    }
    public void Fight()
    {

    }
    public void P1_ready()
    {
        p1 = true;
    }
    public void P2_ready()
    {
        p2 = true;
    }
}
