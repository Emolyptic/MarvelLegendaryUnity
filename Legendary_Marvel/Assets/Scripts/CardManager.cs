using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardManager : MonoBehaviour {
	DataManager gameData;
	MainGame mainGame;

	// Use this for initialization
	void Start () {
		gameData = GameObject.Find("GameData").GetComponent<DataManager>();
		mainGame = GameObject.Find("RunGameObject").GetComponent<MainGame>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public Card getTopCardofDeck(Deck deck)
	{
		Card temp = deck.cards[0];
		deck.cards.RemoveAt(0);
		return temp;
	}

	public void AddCardToPlayersHand(Card card, Player player)
	{
		player.hand.Add(card);
	}

	public void DiscardPlayersHand(Player player)
	{
		while(player.hand.Count != 0)
		{
			AddCardToPlayersDiscard(player.hand[0],player);
			player.hand.RemoveAt(0);
		}
//		if(player.hand.Count != 0){
//			for(int i = 0; i < player.hand.Count; i++)
//			{
//				AddCardToPlayersDiscard(player.hand[i],player);
//			}
//			player.hand.RemoveRange(0,player.hand.Count);
//		}
	}
	public void AddCardToPlayersDiscard(Card card, Player player)
	{
		player.discard.AddCardToDeck(card);
	}

	public void LookatTopCards(Deck deck, int NumOfCards)
	{
		//This needs to do something else with this
	}

	public void DiscardTopCards(Player player, Deck deck, int NumOfCards)
	{
		for(int i = 0; i< NumOfCards; i++)
		{
			player.discard.AddCardToDeck(deck.cards[0]);
			deck.cards.RemoveAt(0);
		}
	}

	public void ShuffleDeck(Deck deck)
	{
		for(int i = 0; i < deck.cards.Count; i++)
		{
			Card temp = deck.cards[i];
			int randomIndex = Random.Range (i, deck.cards.Count);
			deck.cards[i] = deck.cards[randomIndex];
			deck.cards[randomIndex] = temp;
		}
	}

	public void AddAttackBonus(int amount)
	{
		mainGame.currentAttack += amount;
	}

	public void DrawCard(Deck deck, Player player)
	{
		//As long as you have a card to pull
		if(deck.cards.Count != 0)
		{
			player.hand.Add (deck.cards[0]);
			deck.cards.RemoveAt(0);
		}
		else{
			//put all discard into deck
			for(int i = 0; i< player.discard.cards.Count; i++)
			{
				player.deck.AddCardToDeck(player.discard.cards[i]);
			}
			//empty discard deck
			player.discard.cards.RemoveRange(0,player.discard.cards.Count);
			//Shuffle deck
			ShuffleDeck(player.deck);

			//Draw Card that you need
			player.hand.Add (deck.cards[0]);
			deck.cards.RemoveAt(0);
		}
	}

	public void AddRecruit(int amount)
	{
		mainGame.currentRecruit += amount;
	}

	public void KOHero(Hero hero)
	{
		mainGame.KO.Add(hero);
	}

	public void RescueBystander(Deck bystanderDeck, Player player)
	{
		player.victoryPile.AddCardToDeck(bystanderDeck.cards[0]);
		bystanderDeck.cards.RemoveAt(0);
	}

	public void AddBystanderToVillain(Bystander bystander, Villain villain)
	{
		villain.bystanders.Add(bystander);
	}

	public void KOVillain(Villain villain)
	{
		mainGame.KO.Add(villain);
	}

	public Deck ShuffleDecksTogether(Deck deckOne, Deck deckTwo)
	{
		Deck temp = deckOne;
		for(int i = 0; i < deckTwo.cards.Count; i++)
		{
			temp.AddCardToDeck(deckTwo.cards[i]);
		}
		return temp;
	}

	public void AddToVictoryPile(Player player, Card card)
	{
		player.victoryPile.AddCardToDeck(card);
	}

}
