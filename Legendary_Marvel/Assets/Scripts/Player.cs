using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player {
	public int PlayerNumber;

	public List<Card> hand;
	public Deck deck;
	public Deck discard;
	public Deck victoryPile;
	string playerName;

	public Player(string passedName)
	{
		playerName = passedName;
		hand = new List<Card>();
		discard = new Deck();
		deck = new Deck();
		victoryPile = new Deck();
		
		
		deck.AddCardToDeck(new ShieldTrooper());
		deck.AddCardToDeck(new ShieldTrooper());
		deck.AddCardToDeck(new ShieldTrooper());
		deck.AddCardToDeck(new ShieldTrooper());
		
		deck.AddCardToDeck(new ShieldAgent());
		deck.AddCardToDeck(new ShieldAgent());
		deck.AddCardToDeck(new ShieldAgent());
		deck.AddCardToDeck(new ShieldAgent());
		deck.AddCardToDeck(new ShieldAgent());
		deck.AddCardToDeck(new ShieldAgent());
		deck.AddCardToDeck(new ShieldAgent());
		deck.AddCardToDeck(new ShieldAgent());
	}
	// Use this for initialization
	void Awake () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
