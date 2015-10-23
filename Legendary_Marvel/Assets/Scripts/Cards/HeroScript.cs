using UnityEngine;
using System.Collections;

public class HeroScript : MonoBehaviour {

	//private Hero hero;
	//public Hero hero{ get{ return hero; } set{hero = value;}}
	public Hero card;
	public bool inHand;
	public DataManager gameData;
	public MainGame mainGame;
	public CardManager cardManager;

	// Use this for initialization
	void Start () {
		mainGame = GameObject.Find("RunGameObject").GetComponent<MainGame>();
		cardManager = GameObject.Find("RunGameObject").GetComponent<CardManager>();
		gameData = GameObject.Find("GameData").GetComponent<DataManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		if (inHand)
		{
			//Play card

			//Add Attack
			mainGame.currentAttack +=card.Attack;
			//Add Recruit
			mainGame.currentRecruit += card.Recruit;
			//Use special ability
			card.Ability(mainGame.currentPlayer);
			//Add to Discard
			cardManager.AddCardToPlayersDiscard(card, mainGame.currentPlayer);
			//Remove from screen
			mainGame.RemoveCard(this.gameObject);
		}
		else
		{
			Debug.Log ("CLICKED ON NOT IN HAND");
			//Gamedata check recruit of card and of current recruit.
			//if can purchase card. minus recruit, add to player hand.
			//Replace card from the Heroes Deck.
			//Add Texture to Object
			if(mainGame.currentRecruit >= card.Recruit)
			{
				//Subtract Cost
				mainGame.currentRecruit -= card.Recruit;
				//Put card in discard
				cardManager.AddCardToPlayersDiscard(card, mainGame.currentPlayer);
				//Draw new Card
				card = (Hero)cardManager.getTopCardofDeck(gameData.heroDeck);
				this.gameObject.GetComponent<Renderer>().material.mainTexture = card.texture;
			}
		}
	}
}
