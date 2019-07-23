using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
public class Card : ScriptableObject
{
    
    public new string name;
    public string description;

    public Image Hero;

    public int health;
    public int attack;
    public int resistance;
}
