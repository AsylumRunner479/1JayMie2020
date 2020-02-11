using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Card", menuName = "Card/Base")]
public class Card : ScriptableObject
{
    public CardType cardType;
    public new string name;
    public string description;
    public int cost, attack, health;
    public Sprite icon, background;
    public GameObject prefab;
}
