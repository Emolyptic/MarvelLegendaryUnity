using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainGame : MonoBehaviour {
	DataManager gameData;
	CardManager cardManager;
	public GameObject cardPrefab;

	public Player currentPlayer;
	public int currentPlayerNumber = 0;
	public int currentAttack;
	public int currentRecruit;
	public Card drawnVillainCard;
	public List<GameObject> currentPhysicalHand = new List<GameObject>();

	//List<Card> HQ;
	//List<Card> cityScape;
	public List<Card> KO;
	public List<GameObject> gameCityScape;
	public List<GameObject> gameHQ;
	GameObject gameMastermind;
	GameObject gameshield;
	GameObject gameScheme;

	//Variables for making and showing hand.
	bool showHand = false;
	float cardIconXPos = 0;
	float cardIconYPos = Screen.height * .9f;
	float cardIconWidth;
	float cardIconHeight;


	// Use this for initialization
	void Start () {
		//Get GameData and Card Manager
		gameData = GameObject.Find("GameData").GetComponent<DataManager>();
		cardManager = GameObject.Find("RunGameObject").GetComponent<CardManager>();

		//Initialize HQ cards and gameObjects
		//HQ = new List<Card>();
		//cityScape = new List<Card>();
		KO = new List<Card>();
		gameCityScape = new List<GameObject>();
		gameHQ = new List<GameObject>();

		for(int i = 0; i < 5; i++)
		{
			//HQ.Add (null);
			//cityScape.Add(null);
		}

		gameCityScape.Add(GameObject.Find("Sewers"));
		gameCityScape.Add(GameObject.Find("Bank"));
		gameCityScape.Add(GameObject.Find("Rooftops"));
		gameCityScape.Add(GameObject.Find("Streets"));
		gameCityScape.Add(GameObject.Find("Bridge"));

		gameHQ.Add(GameObject.Find ("HQ 1"));
		gameHQ.Add(GameObject.Find ("HQ 2"));
		gameHQ.Add(GameObject.Find ("HQ 3"));
		gameHQ.Add(GameObject.Find ("HQ 4"));
		gameHQ.Add(GameObject.Find ("HQ 5"));

		//Grab GameObjects from around the map
		gameMastermind = GameObject.Find ("MasterMind");
		gameshield = GameObject.Find ("SHIELD");
		gameScheme = GameObject.Find ("Scheme");

		currentPlayer = gameData.playerOrder[0];


		GameBoardSetup();
		NextTurn();
	}
	
	// Update is called once per frame
	void Update () {
		//If Hero Deck Runs out. End game.
		//If Villain Deck runs out?

	}
	void NextTurn(){
		//Start Turn
		drawnVillainCard = gameData.villainDeck.cards[0];
		gameData.villainDeck.cards.RemoveAt(0);
		//Draw Villain Deck
		Debug.Log (drawnVillainCard.cardType + " ::::: " + drawnVillainCard.GetType());
		switch (drawnVillainCard.cardType)
		{
		case Card.CARDTYPE.Bystander:
			bool giveToMasterMind = true;
			//check city for first villain. If not put under Mastermind.
			for (int i = 0; i < gameCityScape.Count; i++)
			{
				if(gameCityScape[i].GetComponent<VillainScript>().card != null)
				{
					gameCityScape[i].GetComponent<VillainScript>().card.bystanders.Add((Bystander)drawnVillainCard);
					giveToMasterMind = false;
					break;
				}
			}
			if(giveToMasterMind)
			{
				gameMastermind.GetComponent<VillainScript>().card.bystanders.Add((Bystander)drawnVillainCard);
			}

			break;
		case Card.CARDTYPE.MasterStrike:
			// Mastermind MasterStrike Ability
			gameData.gameMastermind.MasterStrike();
			break;
		case Card.CARDTYPE.SchemeTwist:
			//Twist happens and update counter
			gameData.gameScheme.Twist(gameData.numberOfTwistsPlayed);
			gameData.numberOfTwistsPlayed++;
			break;
		case Card.CARDTYPE.Villain:
			//check city for last avaliable slot.
			//if none escape last villain.
			//move all villains down one
			//place new villain in first spot.
			bool escaped = true;
			for (int q = 0; q < gameCityScape.Count; q++)
			{
				if(gameCityScape[q].GetComponent<VillainScript>().card != null)
				{
					gameCityScape[q].GetComponent<VillainScript>().card = (Villain)drawnVillainCard;
					gameCityScape[q].GetComponent<Renderer>().material.mainTexture = gameCityScape[q].GetComponent<VillainScript>().card.texture;
					escaped = false;
					break;
				}
			}
			if(escaped)
			{
				gameCityScape[4].GetComponent<VillainScript>().card.EscapeEffect();
				//TODO MOVE THEM ON DOWN!
			}
			break;
		}
		//Scheme Twist

		//Master Strike

		//Bystander

		//Villain to the City

		//Move Villains in city if needs be

		//Escaped Villain


	}


	void GameBoardSetup ()
	{
		//Shuffle Villain and Hero Decks
		cardManager.ShuffleDeck(gameData.heroDeck);
		cardManager.ShuffleDeck(gameData.villainDeck);

		//Make Mastermind Deck look like Mastermind
		gameMastermind.GetComponent<Renderer>().material.mainTexture = gameData.gameMastermind.texture;

		//Make Scheme the right scheme
		gameScheme.GetComponent<Renderer>().material.mainTexture = gameData.gameScheme.texture;

		//Draw the 5 cards from Heroes deck.
		gameHQ[0].GetComponent<HeroScript>().card = (Hero)cardManager.getTopCardofDeck(gameData.heroDeck);
		gameHQ[0].GetComponent<Renderer>().material.mainTexture = gameHQ[0].GetComponent<HeroScript>().card.texture;
		gameHQ[1].GetComponent<HeroScript>().card = (Hero)cardManager.getTopCardofDeck(gameData.heroDeck);
		gameHQ[1].GetComponent<Renderer>().material.mainTexture = gameHQ[1].GetComponent<HeroScript>().card.texture;
		gameHQ[2].GetComponent<HeroScript>().card = (Hero)cardManager.getTopCardofDeck(gameData.heroDeck);
		gameHQ[2].GetComponent<Renderer>().material.mainTexture = gameHQ[2].GetComponent<HeroScript>().card.texture;
		gameHQ[3].GetComponent<HeroScript>().card = (Hero)cardManager.getTopCardofDeck(gameData.heroDeck);
		gameHQ[3].GetComponent<Renderer>().material.mainTexture = gameHQ[3].GetComponent<HeroScript>().card.texture;
		gameHQ[4].GetComponent<HeroScript>().card = (Hero)cardManager.getTopCardofDeck(gameData.heroDeck);
		gameHQ[4].GetComponent<Renderer>().material.mainTexture = gameHQ[4].GetComponent<HeroScript>().card.texture;

		//Shuffle all players decks and give them hands.
		for(int x = 0; x < gameData.playerOrder.Count; x++)
		{
			cardManager.ShuffleDeck(gameData.playerOrder[x].deck);

			for(int c = 0; c < 6; c++)
			{
				cardManager.DrawCard(gameData.playerOrder[x].deck, gameData.playerOrder[x]);
			}
		}
		InstantiatePhysicalHand();

	}

	void InstantiatePhysicalHand ()
	{
		for(int i = 0; i < currentPlayer.hand.Count; i++)
		{
			//TODO Put them in the right spot.
			float xcoor = 36 - (10*i);
			float zcoor = 20f;
			GameObject temp = Instantiate(cardPrefab,new Vector3(xcoor,0,zcoor), Quaternion.identity) as GameObject; //between x = 36 and -25
			temp.AddComponent<HeroScript>();
			temp.GetComponent<HeroScript>().card = (Hero)currentPlayer.hand[i];
			temp.GetComponent<HeroScript>().inHand = true;
			temp.tag = "HandShown";
			temp.GetComponent<Renderer>().material.mainTexture = currentPlayer.hand[i].texture;	
			
			temp.SetActive(false);
			currentPhysicalHand.Add(temp);
		}
	}

	//ON GUI END TURN BUTTON
	//Swap out Current Player
	//Show current Player hand
	void OnGUI()
	{
		//End Turn Button.
		if(GUI.Button(new Rect(Screen.width *.8f,Screen.height * .9f,Screen.width *.2f,Screen.height * .1f),"End Turn"))
		{
			//put hand in discard pile.
			cardManager.DiscardPlayersHand(currentPlayer);

			//Get rid of cards on the screen
			//GameObject[] toDelete = GameObject.FindGameObjectsWithTag("HandShown");
			if(currentPhysicalHand.Count != 0)
			{

				for(int y = 0; y < currentPhysicalHand.Count; y++)
				{
					//currentHand.RemoveAt(y);
					Destroy(currentPhysicalHand[y]);
					//Destroy(toDelete[y]);
				}
				int temp = currentPhysicalHand.Count;
				for(int p = 0; p < temp; p++)
				{
					currentPhysicalHand.RemoveAt(0);
				}
			}
			//Draw cards from deck
			for(int i = 0; i < 6; i++)
			{
				cardManager.DrawCard(currentPlayer.deck, currentPlayer);
			}
			//Next player
			currentPlayerNumber++;
			//Current player is next in the playerorder.
			if(currentPlayerNumber < gameData.numberOfPlayer){
				currentPlayer = gameData.playerOrder[currentPlayerNumber]; //I think the ++ should change the variable if not I will change it.
			}
			else{
				currentPlayer = gameData.playerOrder[0];
				currentPlayerNumber = 0;
			}
			//Instantiate Hand of new player.
			InstantiatePhysicalHand();

			// Run start of next turn
			NextTurn();
		}
		//Toggle Hand button.
		//Show buttons of all cards in their hand
		if(GUI.Button(new Rect(Screen.width *.8f,Screen.height * .8f,Screen.width *.2f,Screen.height * .1f),"Show Hand"))
		{
			showHand = !showHand;
			RevealHand(showHand);
			//Get rid of card hand on screen.
		}

		if(GUI.Button(new Rect(0 ,0 ,Screen.width *.2f,Screen.height * .1f),"Recruit = " + currentRecruit))
		{
		}
		if(GUI.Button(new Rect(0 ,Screen.height * .1f,Screen.width *.2f,Screen.height * .1f),"Attack = " + currentAttack))
		{
		}
		//TODO Clicking on Cards and bringing them to the front ( maybe do this in the HeroScript)
	}

	public void RemoveCard(GameObject toRemove)
	{
		currentPhysicalHand.Remove(toRemove);
		Destroy(toRemove);
	}

	void RevealHand (bool reveal)
	{
		if(reveal)
		{
			for(int y = 0; y < currentPhysicalHand.Count; y++)
			{
				currentPhysicalHand[y].SetActive(true);
			}
			//Move Hand On screen. or make visible.
		}
		else{
			for(int y = 0; y < currentPhysicalHand.Count; y++)
			{
				currentPhysicalHand[y].SetActive(false);
			}
		}
	}
}
	
