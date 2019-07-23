using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clamphealth2 : MonoBehaviour
{
    public GameObject card;
    public static Clamphealth2 ch;
    public Text hp;
    public Text attack;
    public Text resistance;
    private Vector3 offset1,offset2,offset3,cardpos;
    void Start()
    {
        ch = this;
        cardpos = card.transform.position;
        offset1 = hp.transform.position - Camera.main.WorldToScreenPoint(card.transform.position);
        offset2 = attack.transform.position - Camera.main.WorldToScreenPoint(card.transform.position);
        offset3 = resistance.transform.position - Camera.main.WorldToScreenPoint(card.transform.position);
    }
    
    void Update()
    {
        Vector3 namePos = Camera.main.WorldToScreenPoint(card.transform.position);
        hp.transform.position = namePos + offset1;
        attack.transform.position = namePos + offset2;
        resistance.transform.position = namePos + offset3;
        
        if (DragAndDrop.drag._mouseState == false)
        {
            if (P2.col2.p2collided == false)
                card.transform.position = cardpos;
        }
    }

    public void Resetpos()
    {
        card.transform.position = cardpos;
    }
}
