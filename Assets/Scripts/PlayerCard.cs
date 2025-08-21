using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[CreateAssetMenu(fileName = "new PlayerCard", menuName = "PlayerCard")]
public class Card : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite artwork;

    public int manaCost;
    public int attack;
    public int defense;

    public void Print ()
    {
        Debug.Log(manaCost + ": " + attack +  ": " + defense);
    }
}
