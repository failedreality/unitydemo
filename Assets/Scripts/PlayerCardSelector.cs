using System.Collections.Generic;
using System.Globalization;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class PlayerCardSelector : MonoBehaviour
{

    public GameObject[] cards;


    void Start()
    {
        cards = GameObject.FindGameObjectsWithTag("Card");
        for (int i = 0; i < cards.Length; i++)
        {
            CardSelector();
        }
        Debug.Log(cards.Length);
    }

    void CardSelector()
    {
        int randomIndex = Random.Range(0, cards.Length);
        GameObject clone = Instantiate(cards[randomIndex],transform.position, Quaternion.identity);
        Debug.Log(clone);
    }

    private void Update()
    {
        
    }
}
