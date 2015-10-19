using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck {
    List<Card> cards;
    
	// Use this for initialization
	public Deck () {
        cards = new List<Card>();
	}
	
	public void AddCardToDeck(Card toAdd)
    {
        cards.Add(toAdd);
    }
}
