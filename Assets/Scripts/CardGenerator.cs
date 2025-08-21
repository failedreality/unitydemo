using System.Collections.Generic;
using System.Globalization;
using Unity.Burst.Intrinsics;
using System;
using UnityEngine;

public class CardGenerator : MonoBehaviour  //*use this when in Unity environment*
{
    public List<Cards> generatedCards = new();

    void Start()  //void Start() // Use Start() when in Unity environment
    {
        CardGenerator generator = new CardGenerator(); // Create an instance

        System.Random rand = new System.Random();
        for (int i = 1; i <= 10; i++)
        {
            int attack = rand.Next(1, 11); // Random attack value between 1 and 10
            int defense = rand.Next(1, 11); // Random defense value between 1 and 10
            int hitPoints = 21; // Fixed hit points value
            /*
            Not sure how to determine the energy cost quite yet.
            So for now leaving what I have in place below.
            */
            int energyCost = attack * 2 + defense * 2 * hitPoints; //This will need some readjustment.

            Cards card = new Cards
            {
                attack = attack,
                defense = defense,
                hitPoints = hitPoints,
                energyCost = energyCost
            };

            generator.generatedCards.Add(card); // Use the instance to access generatedCards
            Debug.Log(generatedCards.Count); // Log the count of generated cards

            //Console.WriteLine($"Card {i}: {card}");
        }
    }
}
