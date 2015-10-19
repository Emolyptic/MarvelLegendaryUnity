using UnityEngine;
using System.Collections;

public class CardManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void AddCardToPlayersHand(Card card, Player player)
	{
	}

	void AddCardToPlayersDiscard(Card card, Player player)
	{
	}

	void LookatTopCards(Deck deck, int NumOfCards)
	{
	}

	void DiscardTopCards(Deck deck, int NumOfCards)
	{
	}

	void ShuffleDeck(Deck deck)
	{
	}

	void AddAttackBonus(int amount)
	{
	}

	void DrawCard(Deck deck, Player player)
	{
	}

	void AddRecruit(int amount)
	{
	}

	void KOHero(Hero hero)
	{
	}

	void RescueBystander(Deck bystanderDeck, Player player)
	{
	}

	void AddBystanderToVillain(Bystander bystander, Villain villain)
	{
	}

	void KOVillain(Villain villain)
	{
	}

	Deck ShuffleDecksTogether(Deck deckOne, Deck deckTwo)
	{
		return deckOne;
	}

	void AddToVictoryPile(Player player, Card card)
	{
	}

}
