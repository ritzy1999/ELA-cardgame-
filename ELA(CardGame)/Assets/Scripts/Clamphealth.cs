using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clamphealth : MonoBehaviour
{
    public Slider hp;
    private Vector3 offset,cardpos;
    void Start()
    {
        cardpos = this.transform.position;
        offset = hp.transform.position - Camera.main.WorldToScreenPoint(this.transform.position);
    }
    
    void Update()
    {
        Vector3 namePos = Camera.main.WorldToScreenPoint(this.transform.position);
        hp.transform.position = namePos + offset;
    }

    public void Resetpos()
    {
        this.transform.position = cardpos;
    }
}
