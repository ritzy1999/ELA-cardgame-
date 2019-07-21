using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentHp : MonoBehaviour
{
    public Slider p1, p2, p3, p4, p5, p6, p7, p8, p9, p10;
    void Start()
    {
        
    }
    void Update()
    {
        p1.value = HealthRecord.HR.c1;
        p2.value = HealthRecord.HR.c2;
        p3.value = HealthRecord.HR.c3;
        p4.value = HealthRecord.HR.c4;
        p5.value = HealthRecord.HR.c5;
        p6.value = HealthRecord.HR.c6;
        p7.value = HealthRecord.HR.c7;
        p8.value = HealthRecord.HR.c8;
        p9.value = HealthRecord.HR.c9;
        p10.value = HealthRecord.HR.c10;
    }
}
