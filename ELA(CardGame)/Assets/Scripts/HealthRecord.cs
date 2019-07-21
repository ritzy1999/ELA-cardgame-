using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRecord : MonoBehaviour
{
    public static HealthRecord HR = new HealthRecord();
    public int c1, c2, c3, c4, c5, c6, c7, c8, c9, c10;
    public int a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;
    public int r1, r2, r3, r4, r5, r6, r7, r8, r9, r10;
    void Start()
    {
        HR = this;
        c1 = c2 = c3 = c4 = c5 = c6 = c7 = c8 = c9 = c10 = 10;
    }
    
    void Update()
    {
        
    }
}
