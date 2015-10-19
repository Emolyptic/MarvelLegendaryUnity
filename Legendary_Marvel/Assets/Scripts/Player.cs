using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {
	public int PlayerNumber;

	public List<Card> hand;
	public Deck deck;
	public Deck discard;
	public Deck victoryPile;

	// Use this for initialization
	void Start () {
		hand = new List<Card>();
		discard = new Deck();
		deck = new Deck();
		victoryPile = new Deck();


		deck.AddCardToDeck(new ShieldTrooper((Texture2D)Resources.Load("Textures/shield_trooper_20_md")));
		deck.AddCardToDeck(new ShieldTrooper((Texture2D)Resources.Load("Textures/shield_trooper_20_md")));
		deck.AddCardToDeck(new ShieldTrooper((Texture2D)Resources.Load("Textures/shield_trooper_20_md")));
		deck.AddCardToDeck(new ShieldTrooper((Texture2D)Resources.Load("Textures/shield_trooper_20_md")));

		deck.AddCardToDeck(new ShieldAgent((Texture2D)Resources.Load("Textures/shield_agent_40_md")));
		deck.AddCardToDeck(new ShieldAgent((Texture2D)Resources.Load("Textures/shield_agent_40_md")));
		deck.AddCardToDeck(new ShieldAgent((Texture2D)Resources.Load("Textures/shield_agent_40_md")));
		deck.AddCardToDeck(new ShieldAgent((Texture2D)Resources.Load("Textures/shield_agent_40_md")));
		deck.AddCardToDeck(new ShieldAgent((Texture2D)Resources.Load("Textures/shield_agent_40_md")));
		deck.AddCardToDeck(new ShieldAgent((Texture2D)Resources.Load("Textures/shield_agent_40_md")));
		deck.AddCardToDeck(new ShieldAgent((Texture2D)Resources.Load("Textures/shield_agent_40_md")));
		deck.AddCardToDeck(new ShieldAgent((Texture2D)Resources.Load("Textures/shield_agent_40_md")));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
