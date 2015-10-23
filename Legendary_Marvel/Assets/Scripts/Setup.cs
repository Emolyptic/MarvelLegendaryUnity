using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Setup : MonoBehaviour {
	//public GameObject cardObject;
	
	# region Decks
	public Deck VillainDeck;
	public Deck HeroDeck;
	public Deck MastermindDeck;
	public Deck WoundsDeck;
	public Deck BystanderDeck;
	public Deck SHIELDDeck;
	public Deck Escaped;
	public Deck KO;
	#endregion
	
	#region phase 0 miniphase bools
	bool choosePlayer		= false;
	bool chooseHeroes		= false;
	bool chooseHenchmen		= false;
	bool chooseVillain		= false;
	bool chooseMastermind	= false;
	bool chooseScheme 		= false;
	bool selected  			= false;
	//bool enterNames         = false;
	#endregion
	
	#region Saved Data
	public int numberOfPlayer;
	List<string> playerNames = new List<string>(){"","","","",""};
	List<string> selectedHeroes = new List<string>(){"","","","",""};
	public List<string> selectedHenchmen;
	public List<string> selectedVillains;

	string selectedMastermind;
	string selectedScheme;
	public int schemetwistCount;
	
	public Schemes gamesScheme;
	public Mastermind gamesMastermind;
	
	#endregion
	
	#region TODO Replace these with the Dictionaries of Objects
	List<string> heroesList = new List<string>(){
		"Black Widow",
		"Captain America",
		"Cyclops",
		"Deadpool",
		"Emma Frost",
		"Gambit",
		"HawkEye",
		"Hulk",
		"IronMan",
		"Nick Fury",
		"Rogue",
		"Spiderman",
		"Storm",
		"Thor",
		"Wolverine"
	};
	
	public List<string> henchmenList = new List<string>(){
		"DoomBot Legion",
		"Hand Ninjas",
		"Savage Land Mutates",
		"Sentinel"
	};
	
	public List<string> villainList = new List<string>(){
		"Brotherhood",
		"Enemies of Asgard",
		"Hydra",
		"Masters of Evil",
		"Spider foes",
		"Skrull"
	};
	
	List<string> mastermindList = new List<string>(){
		"Doctor Doom",
		"Loki",
		"Magneto",
		"Red Skull"
	};
	
	List<string> schemeList = new List<string>(){
		"The Legacy Virus",
		"Midtown Bank Robbery",
		"Negative Zone Prison Breakout",
		"Portals to the Dark Dimension",
		"Replace Earth's Leaders with KillBots",
		"Secret Invasion of the Skrull Shapeshifters",
		"Super Hero Civil War",
		"Unleash the Power of the Cosmic Cube"
	};
	
	#endregion
	//Screen size usage
	
	static float screenWidth = Screen.width;
	static float screenHeight = Screen.height;
	
	#region Button Positions and Measurements
	
	float playerButtonXPos 		= screenWidth * .01f;
	float playerButtonYPos 		= screenHeight* .01f;
	float playerButtonWidth 	= screenWidth * .18f;
	float playerButtonHeight 	= screenHeight* .1f;

	float playerNameButtonXPos 		= screenWidth * .3f;
	float playerNameButtonYPos 		= screenHeight* .15f;
	float playerNameButtonWidth 	= screenWidth * .15f;
	float playerNameButtonHeight 	= screenHeight* .025f; 
	
	float heroButtonXPos 	= screenWidth * .01f;
	float heroButtonYPos 	= screenHeight* .01f;
	float heroButtonWidth	= screenWidth * .1f;
	float heroButtonHeight 	= screenHeight* .1f;

	float AcceptButtonXPos 		= screenWidth * .4f;
	float AcceptButtonYPos 		= screenHeight* .95f;
	float AcceptButtonWidth		= screenWidth * .18f;
	float AcceptButtonHeight 	= screenHeight* .04f;

	float heroDeclineButtonXPos 	= screenWidth * .6f;
	float heroDeclineButtonYPos 	= screenHeight* .95f;
	float heroDeclineButtonWidth	= screenWidth * .18f;
	float heroDeclineButtonHeight 	= screenHeight* .04f;

	float cardIconXPos 	= screenWidth * .3f;
	float cardIconYPos 	= screenHeight* .1f;
	float cardIconWidth	= screenWidth * .25f;
	float cardIconHeight = screenHeight* .4f;
	
	float henchmenButtonXPos 	= screenWidth * .01f;
	float henchmenButtonYPos 	= screenHeight* .01f;
	float henchmenButtonWidth	= screenWidth * .18f;
	float henchmenButtonHeight 	= screenHeight* .1f;
	
	float villainButtonXPos 	= screenWidth * .01f;
	float villainButtonYPos 	= screenHeight* .01f;
	float villainButtonWidth	= screenWidth * .1f;
	float villainButtonHeight 	= screenHeight* .1f;
	
	float mastermindButtonXPos 	= screenWidth * .01f;
	float mastermindButtonYPos 	= screenHeight* .01f;
	float mastermindButtonWidth	= screenWidth * .1f;
	float mastermindButtonHeight= screenHeight* .1f;
	
	float schemeButtonXPos 	= screenWidth * .01f;
	float schemeButtonYPos 	= screenHeight* .01f;
	float schemeButtonWidth	= screenWidth * .18f;
	float schemeButtonHeight= screenHeight* .1f;
	#endregion

	bool showCards = false;
	int tempint;
	public int listPointer = 0;

	//Temps for Hero selection
	int heroListMax = 5; //Default
	
	public int villainListMax = 0;
	
	public int henchmanListMax = 0;
	public int bystanderListMax = 0;
	

	DataManager gameData;
	
	
	// Use this for initialization
	void Start () {
		choosePlayer = true;
		gameData = GameObject.Find("GameData").GetComponent<DataManager>();

		VillainDeck 	= new Deck();
		HeroDeck		= new Deck();
		MastermindDeck	= new Deck();
		WoundsDeck		= new Deck();
		BystanderDeck	= new Deck();
		SHIELDDeck		= new Deck();
		Escaped			= new Deck();
		KO				= new Deck();
		//GameObject cardPrefab = (GameObject) Instantiate(cardObject);
		//HeroScript script = cardPrefab.AddComponent<HeroScript>();
		//script.Hero =  new BlackWidow.SilentSniper ();
		//SpriteRenderer renderer = cardPrefab.GetComponent<SpriteRenderer> ();
		//renderer.sprite = Sprite.Create(script.Hero.texture,new Rect(10.0f, 10.0f, 10.0f, 10.0f),new Vector2(0.0f, 0.0f));
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnGUI()
	{
			#region Setup
			
			#region Choose Player Amount
			if(choosePlayer)
			{
				for(int i = 0; i < 5; i++)
				{	
					if(GUI.Button(new Rect(playerButtonXPos,playerButtonYPos+(playerButtonHeight*1.2f*i) ,playerButtonWidth, playerButtonHeight),(i+1).ToString() + " Players"))
					{
						numberOfPlayer = i+1;
						selected = true;
					}
				}
				if(selected)
				{
					for (int y = 0; y < numberOfPlayer; y++)
					{
						playerNames[y] = GUI.TextField(new Rect(playerNameButtonXPos,playerNameButtonYPos + (playerNameButtonHeight*4.8f*y),playerNameButtonWidth,playerNameButtonHeight), playerNames[y], 25);
					}

					if(GUI.Button(new Rect(screenWidth*.9f,screenHeight*.9f,screenWidth * .1f,screenHeight * .1f),"Next"))
					{
						chooseMastermind = true;
						choosePlayer = false;
						selected = false;
						switch(numberOfPlayer)
						{
						case 1:
							villainListMax = 2;
							selectedVillains = new List<string>(){"",""};
							
							henchmanListMax = 1;
							selectedHenchmen = new List<string>(){""};
							
							bystanderListMax = 2;
							break;
						case 2:
							villainListMax = 2;
							selectedVillains = new List<string>(){"",""};
							
							henchmanListMax = 1;
							selectedHenchmen = new List<string>(){""};
							
							bystanderListMax = 2;
							break;
						case 3:
							villainListMax = 3;
							selectedVillains = new List<string>(){"","",""};
							
							henchmanListMax = 1;
							selectedHenchmen = new List<string>(){""};
							
							bystanderListMax = 8;
							break;
						case 4:
							villainListMax = 3;
							selectedVillains = new List<string>(){"","",""};
							
							henchmanListMax = 2;
							selectedHenchmen = new List<string>(){"",""};
							
							bystanderListMax = 8;
							break;
						case 5:
							villainListMax = 4;
							selectedVillains = new List<string>(){"","","",""};
							
							henchmanListMax = 2;
							selectedHenchmen = new List<string>(){"",""};
							
							bystanderListMax = 12;
							break;
						}
					}
				}
			}
			#endregion
			#region ChooseMastermind
			//CHOOSE MASTERMIND!
			if(chooseMastermind)
			{
				for(int j = 0; j < mastermindList.Count; j++)
				{
					if(GUI.Button(new Rect(mastermindButtonXPos,screenHeight/mastermindList.Count*j ,mastermindButtonWidth, mastermindButtonHeight), mastermindList[j] ))
					{
						if(!showCards)
						{
							showCards = true;
							tempint = j;
							//selectedMastermind = mastermindList[j];
						}
					}
				}
				
				if(showCards)
				{
					switch(mastermindList[tempint])
					{
						case "Doctor Doom":
							GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.drDoomTextures[0]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.drDoomTextures[1]);
							GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.drDoomTextures[2]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.drDoomTextures[3]);
							break;
						case "Loki":
							GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.lokiTextures[0]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.lokiTextures[1]);
							GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.lokiTextures[2]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.lokiTextures[3]);
							break;
						case "Magneto":
							GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.magnetoTextures[0]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.magnetoTextures[1]);
							GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.magnetoTextures[2]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.magnetoTextures[3]);
							break;
						case "Red Skull":
							GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.redSkullTextures[0]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.redSkullTextures[1]);
							GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.redSkullTextures[2]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.redSkullTextures[3]);
							break;
					}
					if(GUI.Button(new Rect(AcceptButtonXPos,AcceptButtonYPos ,AcceptButtonWidth, AcceptButtonHeight),"Ok" ))
					{
						selectedMastermind = mastermindList[tempint];

						showCards = false;
						tempint = 0;
						listPointer = 0;

						MastermindDeck  = new Deck();
						CreateMastermindDeck();
						
						//This adds the necesary villain to the villain deck and makes sure the
						//player can't pick more villain then they should.
						gamesMastermind.AlwaysLeads(); 
						
						chooseScheme = true;
						chooseMastermind = false;
					}
					if(GUI.Button(new Rect(heroDeclineButtonXPos,heroDeclineButtonYPos , heroDeclineButtonWidth, heroDeclineButtonHeight),"Cancel" ))
					{
						showCards = false;
					}
				}
	
			}
			#endregion
			#region ChooseScheme
			//CHOOSE SCHEME
			if(chooseScheme)
			{
				for(int j = 0; j < schemeList.Count; j++)
				{
					if(GUI.Button(new Rect(schemeButtonXPos,screenHeight/schemeList.Count*j ,schemeButtonWidth, schemeButtonHeight),schemeList[j] ))
					{
						if(!showCards)
						{
							showCards = true;
							tempint = j;
							selectedScheme = schemeList[j];
						}
					}
				}
				
				if(showCards)
				{
					switch(schemeList[tempint])
					{
						case "The Legacy Virus":
							GUI.DrawTexture(new Rect(cardIconXPos,cardIconYPos,cardIconWidth*2,cardIconHeight*2),gameData.schemeTextures[0]);
							break;
						case "Midtown Bank Robbery":
							GUI.DrawTexture(new Rect(cardIconXPos,cardIconYPos,cardIconWidth*2,cardIconHeight*2),gameData.schemeTextures[1]);
							break;
						case "Negative Zone Prison Breakout":
							GUI.DrawTexture(new Rect(cardIconXPos,cardIconYPos,cardIconWidth*2,cardIconHeight*2),gameData.schemeTextures[2]);
							break;
						case "Portals to the Dark Dimension":
							GUI.DrawTexture(new Rect(cardIconXPos,cardIconYPos,cardIconWidth*2,cardIconHeight*2),gameData.schemeTextures[3]);
							break;
						case "Replace Earth's Leaders with KillBots":
							GUI.DrawTexture(new Rect(cardIconXPos,cardIconYPos,cardIconWidth*2,cardIconHeight*2),gameData.schemeTextures[4]);
							break;
						case "Secret Invasion of the Skrull Shapeshifters":
							GUI.DrawTexture(new Rect(cardIconXPos,cardIconYPos,cardIconWidth*2,cardIconHeight*2),gameData.schemeTextures[5]);
							break;
						case "Super Hero Civil War":
							GUI.DrawTexture(new Rect(cardIconXPos,cardIconYPos,cardIconWidth*2,cardIconHeight*2),gameData.schemeTextures[6]);
							break;
						case "Unleash the Power of the Cosmic Cube":
							GUI.DrawTexture(new Rect(cardIconXPos,cardIconYPos,cardIconWidth*2,cardIconHeight*2),gameData.schemeTextures[7]);
							break;
					}
					if(GUI.Button(new Rect(AcceptButtonXPos,AcceptButtonYPos ,AcceptButtonWidth, AcceptButtonHeight),"Ok" ))
					{
						showCards = false;
						tempint = 0;
						listPointer = 0;

						//selectedScheme[listPointer] = schemeList[tempint];

						switch (selectedScheme)
						{
						case "The Legacy Virus":
							gamesScheme = new TheLegacyVirus();
							break;
						case "Midtown Bank Robbery":
							gamesScheme = new MidtownBankRobbery();
							break;
						case "Negative Zone Prison Breakout":
							gamesScheme = new NegativeZonePrisonBreakout();
							break;
						case "Portals to the Dark Dimension":
							gamesScheme = new PortalsToTheDarkDimension();
							break;
						case "Replace Earth's Leaders with KillBots":
							gamesScheme = new ReplaceEarthsLeaderswithKillbots();
							break;
						case "Secret Invasion of the Skrull Shapeshifters":
							gamesScheme = new SecretInvasionoftheSkrullShapeshifters();
							break;
						case "Super Hero Civil War":
							gamesScheme = new SuperHeroCivilWar();
							break;
						case "Unleash the Power of the Cosmic Cube":
							gamesScheme = new UnleashthePoweroftheCosmicCube();
							break;
						}
						gamesScheme.PreSetup();
						chooseHeroes = true;
						chooseScheme = false;
					}
					if(GUI.Button(new Rect(heroDeclineButtonXPos,heroDeclineButtonYPos , heroDeclineButtonWidth, heroDeclineButtonHeight),"Cancel" ))
					{
						showCards = false;
					}

				}
			}
			#endregion
			#region ChooseHero
			//CHOOSE HERO PHASE
			if(chooseHeroes)
			{
				for(int j = 0; j < heroesList.Count; j++)
				{
					if(GUI.Button(new Rect(heroButtonXPos,(screenHeight/heroesList.Count*j) ,heroButtonWidth, screenHeight/heroesList.Count),heroesList[j] ))
					{
						if(!showCards)
						{
							showCards = true;
							tempint = j;
						}
					}
				}

				if(showCards)
				{
					switch(heroesList[tempint])
						{
						case "Black Widow":
							GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.blackWidowTextures[0]);
					        GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.blackWidowTextures[1]);
					       	GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.blackWidowTextures[2]);
					        GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.blackWidowTextures[3]);
							break;
						case "Captain America":
							GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.captainAmericaTextures[0]);
			                GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.captainAmericaTextures[1]);
			                GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.captainAmericaTextures[2]);
					        GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.captainAmericaTextures[3]);
							break;
						case "Cyclops":
							GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.cyclopsTextures[0]);
			                GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.cyclopsTextures[1]);
			                GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.cyclopsTextures[2]);
			                GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.cyclopsTextures[3]);
							break;
						case "Deadpool":
							GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.deadpoolTextures[0]);
			                GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.deadpoolTextures[1]);
			                GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.deadpoolTextures[2]);
			                GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.deadpoolTextures[3]);
							break;
						case "Emma Frost":
			                GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.emmaFrostTextures[0]);
			                GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.emmaFrostTextures[1]);
			                GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.emmaFrostTextures[2]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.emmaFrostTextures[3]);
							break;
						case "Gambit":
			                GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.gambitTextures[0]);
			                GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.gambitTextures[1]);
			                GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.gambitTextures[2]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.gambitTextures[3]);
							break;
						case "HawkEye":
			                GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.hawkEyeTextures[0]);
			                GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.hawkEyeTextures[1]);
			                GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.hawkEyeTextures[2]);
			                GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.hawkEyeTextures[3]);
							break;
						case "Hulk":
							GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.hulkTextures[0]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.hulkTextures[1]);
							GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.hulkTextures[2]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.hulkTextures[3]);
							break;
						case "IronMan":
							GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.ironManTextures[0]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.ironManTextures[1]);
							GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.ironManTextures[2]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.ironManTextures[3]);
							break;
						case "Nick Fury":
							GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.nickFuryTextures[0]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.nickFuryTextures[1]);
							GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.nickFuryTextures[2]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.nickFuryTextures[3]);
							break;
						case "Rogue":
							GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.rogueTextures[0]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.rogueTextures[1]);
							GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.rogueTextures[2]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.rogueTextures[3]);
							break;
						case "Spiderman":
							GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.spidermanTextures[0]);
			                GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.spidermanTextures[1]);
			                GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.spidermanTextures[2]);
			                GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.spidermanTextures[3]);
							break;
						case "Storm":
							GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.stormTextures[0]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.stormTextures[1]);
							GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.stormTextures[2]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.stormTextures[3]);
							break;
						case "Thor":
							GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.thorTextures[0]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.thorTextures[1]);
							GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.thorTextures[2]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.thorTextures[3]);
							break;
						case "Wolverine":
							GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.wolverineTextures[0]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.wolverineTextures[1]);
							GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.wolverineTextures[2]);
							GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.wolverineTextures[3]);
							break;
						}
						if(GUI.Button(new Rect(AcceptButtonXPos,AcceptButtonYPos ,AcceptButtonWidth, AcceptButtonHeight),"Ok" ))
						{
							showCards = false;
							selectedHeroes[listPointer] = heroesList[tempint];
							listPointer++;
					        heroesList.RemoveAt(tempint);
						}
						if(GUI.Button(new Rect(heroDeclineButtonXPos,heroDeclineButtonYPos , heroDeclineButtonWidth, heroDeclineButtonHeight),"Cancel" ))
						{
							showCards = false;
						}

				}
				
				if(listPointer >= heroListMax)
				{
						showCards = false;
						tempint = 0;
						listPointer = 0;

						chooseHenchmen = true;
						chooseHeroes = false;
				}
			}
			#endregion
			#region ChooseHenchmen
			//CHOOSE HENCHMEN PHASE
			if(chooseHenchmen)
			{
				//If you don't need henchmen because it was chosen for you by your Mastermind. Skip this phase.
				if(henchmanListMax <= 0)
				{
					chooseVillain = true;
					chooseHenchmen = false;
					selected = false;
				}
				
				for(int j = 0; j < henchmenList.Count; j++)
				{
					if(GUI.Button(new Rect(henchmenButtonXPos,screenHeight/henchmenList.Count*j ,henchmenButtonWidth, henchmenButtonHeight),henchmenList[j] ))
					{
						if(!showCards)
						{
							showCards = true;
							tempint = j;
						}
					}
				}

				if(showCards)
				{
					switch(henchmenList[tempint])
					{
						case "DoomBot Legion":
							GUI.DrawTexture(new Rect(cardIconXPos,cardIconYPos,cardIconWidth*2,cardIconHeight*2),gameData.henchmenTextures[0]);
							break;
						case "Hand Ninjas":
							GUI.DrawTexture(new Rect(cardIconXPos,cardIconYPos,cardIconWidth*2,cardIconHeight*2),gameData.henchmenTextures[1]);
							break;
						case "Savage Land Mutates":
							GUI.DrawTexture(new Rect(cardIconXPos,cardIconYPos,cardIconWidth*2,cardIconHeight*2),gameData.henchmenTextures[2]);
							break;
						case "Sentinel":
							GUI.DrawTexture(new Rect(cardIconXPos,cardIconYPos,cardIconWidth*2,cardIconHeight*2),gameData.henchmenTextures[3]);
							break;
					}
					if(GUI.Button(new Rect(AcceptButtonXPos,AcceptButtonYPos ,AcceptButtonWidth, AcceptButtonHeight),"Ok" ))
					{
						showCards = false;
						selectedHenchmen[listPointer] = henchmenList[tempint];
						listPointer++;
						henchmenList.RemoveAt(tempint);
					}
					if(GUI.Button(new Rect(heroDeclineButtonXPos,heroDeclineButtonYPos , heroDeclineButtonWidth, heroDeclineButtonHeight),"Cancel" ))
					{
						showCards = false;
					}
				}
				if(listPointer == henchmanListMax)
				{
						showCards = false;
						tempint = 0;
						listPointer = 0;

						chooseVillain = true;
						chooseHenchmen = false;
						selected = false;
				}
			}
			#endregion
			#region ChooseVillain
			//CHOOSE VILLAIN PHASE
			if(chooseVillain)
			{
				if(villainListMax <=0)
				{
					StartGame();
				}
				for(int j = 0; j < villainList.Count; j++)
				{
					if(GUI.Button(new Rect(villainButtonXPos,screenHeight/villainList.Count*j ,villainButtonWidth, villainButtonHeight),villainList[j] ))
					{
						if(!showCards)
						{
							showCards = true;
							tempint = j;
						}
					}
				}
				if(showCards)
				{
					switch(villainList[tempint])
					{

					case "Brotherhood":
						GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.brotherhoodTextures[0]);
						GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.brotherhoodTextures[1]);
						GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.brotherhoodTextures[2]);
						GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.brotherhoodTextures[3]);
						break;

					case "Enemies of Asgard":
						GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.enemiesOfAsgardTextures[0]);
						GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.enemiesOfAsgardTextures[1]);
						GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.enemiesOfAsgardTextures[2]);
						GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.enemiesOfAsgardTextures[3]);
						break;

					case "Hydra":
						GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.hydraTextures[0]);
						GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.hydraTextures[1]);
						GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.hydraTextures[2]);
						GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.hydraTextures[3]);
						break;

					case "Masters of Evil":
						GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.mastersOfEvilTextures[0]);
						GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.mastersOfEvilTextures[1]);
						GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.mastersOfEvilTextures[2]);
						GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.mastersOfEvilTextures[3]);
						break;

					case "Spider foes":
						GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.spiderFoesTextures[0]);
						GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.spiderFoesTextures[1]);
						GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.spiderFoesTextures[2]);
						GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.spiderFoesTextures[3]);
						break;

					case "Skrull":
						GUI.DrawTexture(new Rect(cardIconXPos                ,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.skrullsTextures[0]);
						GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos                 ,cardIconWidth,cardIconHeight),gameData.skrullsTextures[1]);
						GUI.DrawTexture(new Rect(cardIconXPos				 ,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.skrullsTextures[2]);
						GUI.DrawTexture(new Rect(cardIconXPos + cardIconWidth,cardIconYPos + cardIconHeight,cardIconWidth,cardIconHeight),gameData.skrullsTextures[3]);
						break;
					}
					if(GUI.Button(new Rect(AcceptButtonXPos,AcceptButtonYPos ,AcceptButtonWidth, AcceptButtonHeight),"Ok" ))
					{
						showCards = false;
						selectedVillains[listPointer] = villainList[tempint];
						listPointer++;
						villainList.RemoveAt(tempint);
					}
					if(GUI.Button(new Rect(heroDeclineButtonXPos,heroDeclineButtonYPos , heroDeclineButtonWidth, heroDeclineButtonHeight),"Cancel" ))
					{
						showCards = false;
					}
				}
				if(listPointer == villainListMax)
				{
						StartGame ();
				}
			}
			#endregion
			#endregion
	}
	
	void CreateChosenDecks()
	{
		VillainDeck     = new Deck();
		CreateVillainDeck();
		
		HeroDeck        = new Deck();
		CreateHeroDeck();	
	}

	void CreatePlayers ()
	{
		for(int v = 0; v < numberOfPlayer; v++)
		{
			GameObject.Find("GameData").GetComponent<DataManager>().playerOrder.Add(new Player(playerNames[v]));
		}
	}
	
	void CreateMastermindDeck()
	{
		switch(selectedMastermind)
		{
		case "Red Skull":
			gamesMastermind = new MMRedSkull();
			MastermindDeck.AddCardToDeck(new RedSkull.EndlessResources());
			MastermindDeck.AddCardToDeck(new RedSkull.HydraConspiracy());
			MastermindDeck.AddCardToDeck(new RedSkull.NegablastGrenades());
			MastermindDeck.AddCardToDeck(new RedSkull.RuthlessDictator());
			break;
		case "Loki":
			gamesMastermind = new MMLoki();
			MastermindDeck.AddCardToDeck(new Loki.CruelRuler());
			MastermindDeck.AddCardToDeck(new Loki.ManiacalTyrant());
			MastermindDeck.AddCardToDeck(new Loki.VanishingIllusions());
			MastermindDeck.AddCardToDeck(new Loki.WhispersAndLies());
			break;
		case "Magneto":
			gamesMastermind = new MMMagneto();
			MastermindDeck.AddCardToDeck(new Magneto.BitterCaptor());
			MastermindDeck.AddCardToDeck(new Magneto.CrushingShockwave());
			MastermindDeck.AddCardToDeck(new Magneto.ElectromagneticBubble());
			MastermindDeck.AddCardToDeck(new Magneto.XaviersNemesis());
			break;
		case"Doctor Doom":
				gamesMastermind = new MMDrDoom();
			MastermindDeck.AddCardToDeck(new DrDoom.DarkTechnology());
			MastermindDeck.AddCardToDeck(new DrDoom.MonarchsDecree());
			MastermindDeck.AddCardToDeck(new DrDoom.SecretsOfTimeTravel());
			MastermindDeck.AddCardToDeck(new DrDoom.TreasuresOfLatveria());
			break;
		}
		
	}
	
	void CreateHeroDeck()
	{
		for(int d = 0; d < selectedHeroes.Count; d++)
		{
			switch(selectedHeroes[d])
			{
			case "Black Widow":
				HeroDeck.AddCardToDeck(new BlackWidow.SilentSniper());
				HeroDeck.AddCardToDeck(new BlackWidow.CovertOperation());
				HeroDeck.AddCardToDeck(new BlackWidow.CovertOperation());
				HeroDeck.AddCardToDeck(new BlackWidow.CovertOperation());
				HeroDeck.AddCardToDeck(new BlackWidow.DangerousRescue());
				HeroDeck.AddCardToDeck(new BlackWidow.DangerousRescue());
				HeroDeck.AddCardToDeck(new BlackWidow.DangerousRescue());
				HeroDeck.AddCardToDeck(new BlackWidow.DangerousRescue());
				HeroDeck.AddCardToDeck(new BlackWidow.DangerousRescue());
				HeroDeck.AddCardToDeck(new BlackWidow.MissionAccomplished());
				HeroDeck.AddCardToDeck(new BlackWidow.MissionAccomplished());
				HeroDeck.AddCardToDeck(new BlackWidow.MissionAccomplished());
				HeroDeck.AddCardToDeck(new BlackWidow.MissionAccomplished());
				HeroDeck.AddCardToDeck(new BlackWidow.MissionAccomplished());
				break;
			case "Captain America":
				HeroDeck.AddCardToDeck(new CaptainAmerica.ADayUnlikeAnyOther());
				HeroDeck.AddCardToDeck(new CaptainAmerica.DivingBlocks());
				HeroDeck.AddCardToDeck(new CaptainAmerica.DivingBlocks());
				HeroDeck.AddCardToDeck(new CaptainAmerica.DivingBlocks());
				HeroDeck.AddCardToDeck(new CaptainAmerica.AvengersAssemble());
				HeroDeck.AddCardToDeck(new CaptainAmerica.AvengersAssemble());
				HeroDeck.AddCardToDeck(new CaptainAmerica.AvengersAssemble());
				HeroDeck.AddCardToDeck(new CaptainAmerica.AvengersAssemble());
				HeroDeck.AddCardToDeck(new CaptainAmerica.AvengersAssemble());
				HeroDeck.AddCardToDeck(new CaptainAmerica.PerfectTeamwork());
				HeroDeck.AddCardToDeck(new CaptainAmerica.PerfectTeamwork());
				HeroDeck.AddCardToDeck(new CaptainAmerica.PerfectTeamwork());
				HeroDeck.AddCardToDeck(new CaptainAmerica.PerfectTeamwork());
				HeroDeck.AddCardToDeck(new CaptainAmerica.PerfectTeamwork());
				break;
			case "Cyclops":
				HeroDeck.AddCardToDeck(new Cyclops.XmenUnited());
				HeroDeck.AddCardToDeck(new Cyclops.UnendingEnergy());
				HeroDeck.AddCardToDeck(new Cyclops.UnendingEnergy());
				HeroDeck.AddCardToDeck(new Cyclops.UnendingEnergy());
				HeroDeck.AddCardToDeck(new Cyclops.OpticBlast());
				HeroDeck.AddCardToDeck(new Cyclops.OpticBlast());
				HeroDeck.AddCardToDeck(new Cyclops.OpticBlast());
				HeroDeck.AddCardToDeck(new Cyclops.OpticBlast());
				HeroDeck.AddCardToDeck(new Cyclops.OpticBlast());
				HeroDeck.AddCardToDeck(new Cyclops.Determination());
				HeroDeck.AddCardToDeck(new Cyclops.Determination());
				HeroDeck.AddCardToDeck(new Cyclops.Determination());
				HeroDeck.AddCardToDeck(new Cyclops.Determination());
				HeroDeck.AddCardToDeck(new Cyclops.Determination());
				break;
			case "Deadpool":
				HeroDeck.AddCardToDeck(new Deadpool.RandomActsOfUnkindness());
				HeroDeck.AddCardToDeck(new Deadpool.HeyCanIGetADoOver());
				HeroDeck.AddCardToDeck(new Deadpool.HeyCanIGetADoOver());
				HeroDeck.AddCardToDeck(new Deadpool.HeyCanIGetADoOver());
				HeroDeck.AddCardToDeck(new Deadpool.Oddball());
				HeroDeck.AddCardToDeck(new Deadpool.Oddball());
				HeroDeck.AddCardToDeck(new Deadpool.Oddball());
				HeroDeck.AddCardToDeck(new Deadpool.Oddball());
				HeroDeck.AddCardToDeck(new Deadpool.Oddball());
				HeroDeck.AddCardToDeck(new Deadpool.HereHoldThisForASecond());
				HeroDeck.AddCardToDeck(new Deadpool.HereHoldThisForASecond());
				HeroDeck.AddCardToDeck(new Deadpool.HereHoldThisForASecond());
				HeroDeck.AddCardToDeck(new Deadpool.HereHoldThisForASecond());
				HeroDeck.AddCardToDeck(new Deadpool.HereHoldThisForASecond());
				break;
			case "Emma Frost":
				HeroDeck.AddCardToDeck(new EmmaFrost.DiamondForm());
				HeroDeck.AddCardToDeck(new EmmaFrost.PsychicLink());
				HeroDeck.AddCardToDeck(new EmmaFrost.PsychicLink());
				HeroDeck.AddCardToDeck(new EmmaFrost.PsychicLink());
				HeroDeck.AddCardToDeck(new EmmaFrost.MentalDiscipline());
				HeroDeck.AddCardToDeck(new EmmaFrost.MentalDiscipline());
				HeroDeck.AddCardToDeck(new EmmaFrost.MentalDiscipline());
				HeroDeck.AddCardToDeck(new EmmaFrost.MentalDiscipline());
				HeroDeck.AddCardToDeck(new EmmaFrost.MentalDiscipline());
				HeroDeck.AddCardToDeck(new EmmaFrost.ShadowedThoughts());
				HeroDeck.AddCardToDeck(new EmmaFrost.ShadowedThoughts());
				HeroDeck.AddCardToDeck(new EmmaFrost.ShadowedThoughts());
				HeroDeck.AddCardToDeck(new EmmaFrost.ShadowedThoughts());
				HeroDeck.AddCardToDeck(new EmmaFrost.ShadowedThoughts());
				break;
			case "Gambit":
				HeroDeck.AddCardToDeck(new Gambit.HighStakesJackpot());
				HeroDeck.AddCardToDeck(new Gambit.HypnoticCharm());
				HeroDeck.AddCardToDeck(new Gambit.HypnoticCharm());
				HeroDeck.AddCardToDeck(new Gambit.HypnoticCharm());
				HeroDeck.AddCardToDeck(new Gambit.CardShark());
				HeroDeck.AddCardToDeck(new Gambit.CardShark());
				HeroDeck.AddCardToDeck(new Gambit.CardShark());
				HeroDeck.AddCardToDeck(new Gambit.CardShark());
				HeroDeck.AddCardToDeck(new Gambit.CardShark());
				HeroDeck.AddCardToDeck(new Gambit.StackTheDeck());
				HeroDeck.AddCardToDeck(new Gambit.StackTheDeck());
				HeroDeck.AddCardToDeck(new Gambit.StackTheDeck());
				HeroDeck.AddCardToDeck(new Gambit.StackTheDeck());
				HeroDeck.AddCardToDeck(new Gambit.StackTheDeck());
				break;
			case "HawkEye":
				HeroDeck.AddCardToDeck(new Hawkeye.ImpossibleTrickShot());
				HeroDeck.AddCardToDeck(new Hawkeye.CoveringFire());
				HeroDeck.AddCardToDeck(new Hawkeye.CoveringFire());
				HeroDeck.AddCardToDeck(new Hawkeye.CoveringFire());
				HeroDeck.AddCardToDeck(new Hawkeye.QuickDraw());
				HeroDeck.AddCardToDeck(new Hawkeye.QuickDraw());
				HeroDeck.AddCardToDeck(new Hawkeye.QuickDraw());
				HeroDeck.AddCardToDeck(new Hawkeye.QuickDraw());
				HeroDeck.AddCardToDeck(new Hawkeye.QuickDraw());
				HeroDeck.AddCardToDeck(new Hawkeye.TeamPlayer());
				HeroDeck.AddCardToDeck(new Hawkeye.TeamPlayer());
				HeroDeck.AddCardToDeck(new Hawkeye.TeamPlayer());
				HeroDeck.AddCardToDeck(new Hawkeye.TeamPlayer());
				HeroDeck.AddCardToDeck(new Hawkeye.TeamPlayer());
				break;
			case "Hulk":
				HeroDeck.AddCardToDeck(new Hulk.HulkSmash());
				HeroDeck.AddCardToDeck(new Hulk.CrazedRampage());
				HeroDeck.AddCardToDeck(new Hulk.CrazedRampage());
				HeroDeck.AddCardToDeck(new Hulk.CrazedRampage());
				HeroDeck.AddCardToDeck(new Hulk.UnstoppableHulk());
				HeroDeck.AddCardToDeck(new Hulk.UnstoppableHulk());
				HeroDeck.AddCardToDeck(new Hulk.UnstoppableHulk());
				HeroDeck.AddCardToDeck(new Hulk.UnstoppableHulk());
				HeroDeck.AddCardToDeck(new Hulk.UnstoppableHulk());
				HeroDeck.AddCardToDeck(new Hulk.GrowingAnger());
				HeroDeck.AddCardToDeck(new Hulk.GrowingAnger());
				HeroDeck.AddCardToDeck(new Hulk.GrowingAnger());
				HeroDeck.AddCardToDeck(new Hulk.GrowingAnger());
				HeroDeck.AddCardToDeck(new Hulk.GrowingAnger());
				break;
			case "IronMan":
				HeroDeck.AddCardToDeck(new IronMan.QuantumBreakthrough());
				HeroDeck.AddCardToDeck(new IronMan.ArcReactor());
				HeroDeck.AddCardToDeck(new IronMan.ArcReactor());
				HeroDeck.AddCardToDeck(new IronMan.ArcReactor());
				HeroDeck.AddCardToDeck(new IronMan.RepulsorRays());
				HeroDeck.AddCardToDeck(new IronMan.RepulsorRays());
				HeroDeck.AddCardToDeck(new IronMan.RepulsorRays());
				HeroDeck.AddCardToDeck(new IronMan.RepulsorRays());
				HeroDeck.AddCardToDeck(new IronMan.RepulsorRays());
				HeroDeck.AddCardToDeck(new IronMan.EndlessInvention());
				HeroDeck.AddCardToDeck(new IronMan.EndlessInvention());
				HeroDeck.AddCardToDeck(new IronMan.EndlessInvention());
				HeroDeck.AddCardToDeck(new IronMan.EndlessInvention());
				HeroDeck.AddCardToDeck(new IronMan.EndlessInvention());
				break;
			case "Nick Fury":
				HeroDeck.AddCardToDeck(new NickFury.PureFury());
				HeroDeck.AddCardToDeck(new NickFury.LegendaryCommander());
				HeroDeck.AddCardToDeck(new NickFury.LegendaryCommander());
				HeroDeck.AddCardToDeck(new NickFury.LegendaryCommander());
				HeroDeck.AddCardToDeck(new NickFury.BattlefieldPromotion());
				HeroDeck.AddCardToDeck(new NickFury.BattlefieldPromotion());
				HeroDeck.AddCardToDeck(new NickFury.BattlefieldPromotion());
				HeroDeck.AddCardToDeck(new NickFury.BattlefieldPromotion());
				HeroDeck.AddCardToDeck(new NickFury.BattlefieldPromotion());
				HeroDeck.AddCardToDeck(new NickFury.HighTechWeaponry());
				HeroDeck.AddCardToDeck(new NickFury.HighTechWeaponry());
				HeroDeck.AddCardToDeck(new NickFury.HighTechWeaponry());
				HeroDeck.AddCardToDeck(new NickFury.HighTechWeaponry());
				HeroDeck.AddCardToDeck(new NickFury.HighTechWeaponry());
				break;
			case "Rogue":
				HeroDeck.AddCardToDeck(new Rogue.StealAbilities());
				HeroDeck.AddCardToDeck(new Rogue.CopyPowers());
				HeroDeck.AddCardToDeck(new Rogue.CopyPowers());
				HeroDeck.AddCardToDeck(new Rogue.CopyPowers());
				HeroDeck.AddCardToDeck(new Rogue.BorrowedBrawn());
				HeroDeck.AddCardToDeck(new Rogue.BorrowedBrawn());
				HeroDeck.AddCardToDeck(new Rogue.BorrowedBrawn());
				HeroDeck.AddCardToDeck(new Rogue.BorrowedBrawn());
				HeroDeck.AddCardToDeck(new Rogue.BorrowedBrawn());
				HeroDeck.AddCardToDeck(new Rogue.EnergyDrain());
				HeroDeck.AddCardToDeck(new Rogue.EnergyDrain());
				HeroDeck.AddCardToDeck(new Rogue.EnergyDrain());
				HeroDeck.AddCardToDeck(new Rogue.EnergyDrain());
				HeroDeck.AddCardToDeck(new Rogue.EnergyDrain());
				break;
			case "Spiderman":
				HeroDeck.AddCardToDeck(new SpiderMan.TheAmazingSpiderMan());
				HeroDeck.AddCardToDeck(new SpiderMan.WebShooter());
				HeroDeck.AddCardToDeck(new SpiderMan.WebShooter());
				HeroDeck.AddCardToDeck(new SpiderMan.WebShooter());
				HeroDeck.AddCardToDeck(new SpiderMan.GreatResponsibility());
				HeroDeck.AddCardToDeck(new SpiderMan.GreatResponsibility());
				HeroDeck.AddCardToDeck(new SpiderMan.GreatResponsibility());
				HeroDeck.AddCardToDeck(new SpiderMan.GreatResponsibility());
				HeroDeck.AddCardToDeck(new SpiderMan.GreatResponsibility());
				HeroDeck.AddCardToDeck(new SpiderMan.AstonishingStrength());
				HeroDeck.AddCardToDeck(new SpiderMan.AstonishingStrength());
				HeroDeck.AddCardToDeck(new SpiderMan.AstonishingStrength());
				HeroDeck.AddCardToDeck(new SpiderMan.AstonishingStrength());
				HeroDeck.AddCardToDeck(new SpiderMan.AstonishingStrength());
				break;
			case "Storm":
				HeroDeck.AddCardToDeck(new Storm.TidalWave());
				HeroDeck.AddCardToDeck(new Storm.SpinningCyclone());
				HeroDeck.AddCardToDeck(new Storm.SpinningCyclone());
				HeroDeck.AddCardToDeck(new Storm.SpinningCyclone());
				HeroDeck.AddCardToDeck(new Storm.LightningBolt());
				HeroDeck.AddCardToDeck(new Storm.LightningBolt());
				HeroDeck.AddCardToDeck(new Storm.LightningBolt());
				HeroDeck.AddCardToDeck(new Storm.LightningBolt());
				HeroDeck.AddCardToDeck(new Storm.LightningBolt());
				HeroDeck.AddCardToDeck(new Storm.GatheringStormClouds());
				HeroDeck.AddCardToDeck(new Storm.GatheringStormClouds());
				HeroDeck.AddCardToDeck(new Storm.GatheringStormClouds());
				HeroDeck.AddCardToDeck(new Storm.GatheringStormClouds());
				HeroDeck.AddCardToDeck(new Storm.GatheringStormClouds());
				break;
			case "Thor":
				HeroDeck.AddCardToDeck(new Thor.GodOfThunder());
				HeroDeck.AddCardToDeck(new Thor.CallLightning());
				HeroDeck.AddCardToDeck(new Thor.CallLightning());
				HeroDeck.AddCardToDeck(new Thor.CallLightning());
				HeroDeck.AddCardToDeck(new Thor.SurgeOfPower());
				HeroDeck.AddCardToDeck(new Thor.SurgeOfPower());
				HeroDeck.AddCardToDeck(new Thor.SurgeOfPower());
				HeroDeck.AddCardToDeck(new Thor.SurgeOfPower());
				HeroDeck.AddCardToDeck(new Thor.SurgeOfPower());
				HeroDeck.AddCardToDeck(new Thor.Odinson());
				HeroDeck.AddCardToDeck(new Thor.Odinson());
				HeroDeck.AddCardToDeck(new Thor.Odinson());
				HeroDeck.AddCardToDeck(new Thor.Odinson());
				HeroDeck.AddCardToDeck(new Thor.Odinson());
				break;
			case "Wolverine":
				HeroDeck.AddCardToDeck(new Wolverine.BerserkerRage());
				HeroDeck.AddCardToDeck(new Wolverine.FrenziedSlashing());
				HeroDeck.AddCardToDeck(new Wolverine.FrenziedSlashing());
				HeroDeck.AddCardToDeck(new Wolverine.FrenziedSlashing());
				HeroDeck.AddCardToDeck(new Wolverine.HealingFactor());
				HeroDeck.AddCardToDeck(new Wolverine.HealingFactor());
				HeroDeck.AddCardToDeck(new Wolverine.HealingFactor());
				HeroDeck.AddCardToDeck(new Wolverine.HealingFactor());
				HeroDeck.AddCardToDeck(new Wolverine.HealingFactor());
				HeroDeck.AddCardToDeck(new Wolverine.KeenSenses());
				HeroDeck.AddCardToDeck(new Wolverine.KeenSenses());
				HeroDeck.AddCardToDeck(new Wolverine.KeenSenses());
				HeroDeck.AddCardToDeck(new Wolverine.KeenSenses());
				HeroDeck.AddCardToDeck(new Wolverine.KeenSenses());
				break;
			}
		}
	}
	
	void CreateVillainDeck()
	{
		for (int e = 0; e < selectedVillains.Count; e++)
		{
			switch (selectedVillains[e])
			{
			case "Brotherhood":
				VillainDeck.AddCardToDeck(new Brotherhood.Blob());
				VillainDeck.AddCardToDeck(new Brotherhood.Blob());
				VillainDeck.AddCardToDeck(new Brotherhood.Juggernaut());
				VillainDeck.AddCardToDeck(new Brotherhood.Juggernaut());
				VillainDeck.AddCardToDeck(new Brotherhood.Mystique());
				VillainDeck.AddCardToDeck(new Brotherhood.Mystique());
				VillainDeck.AddCardToDeck(new Brotherhood.Sabertooth());
				VillainDeck.AddCardToDeck(new Brotherhood.Sabertooth());
				break;
			case "Enemies of Asgard":
				VillainDeck.AddCardToDeck(new EnemiesOfAsgard.Destroyer());
				VillainDeck.AddCardToDeck(new EnemiesOfAsgard.Enchantress());
				VillainDeck.AddCardToDeck(new EnemiesOfAsgard.Enchantress());
				VillainDeck.AddCardToDeck(new EnemiesOfAsgard.FrostGiant());
				VillainDeck.AddCardToDeck(new EnemiesOfAsgard.FrostGiant());
				VillainDeck.AddCardToDeck(new EnemiesOfAsgard.FrostGiant());
				VillainDeck.AddCardToDeck(new EnemiesOfAsgard.YmirFrostGiantKing());
				VillainDeck.AddCardToDeck(new EnemiesOfAsgard.YmirFrostGiantKing());
				break;
			case "Hydra":
				VillainDeck.AddCardToDeck(new Hydra.EndlessArmiesofHydra());
				VillainDeck.AddCardToDeck(new Hydra.EndlessArmiesofHydra());
				VillainDeck.AddCardToDeck(new Hydra.EndlessArmiesofHydra());
				VillainDeck.AddCardToDeck(new Hydra.HydraKidnappers());
				VillainDeck.AddCardToDeck(new Hydra.HydraKidnappers());
				VillainDeck.AddCardToDeck(new Hydra.HydraKidnappers());
				VillainDeck.AddCardToDeck(new Hydra.SupremeHydra());
				VillainDeck.AddCardToDeck(new Hydra.Viper());
				break;
			case "Masters of Evil":
				VillainDeck.AddCardToDeck(new MasterOfEvil.BaronZemo());
				VillainDeck.AddCardToDeck(new MasterOfEvil.BaronZemo());
				VillainDeck.AddCardToDeck(new MasterOfEvil.Melter());
				VillainDeck.AddCardToDeck(new MasterOfEvil.Melter());
				VillainDeck.AddCardToDeck(new MasterOfEvil.Ultron());
				VillainDeck.AddCardToDeck(new MasterOfEvil.Ultron());
				VillainDeck.AddCardToDeck(new MasterOfEvil.Whirlwind());
				VillainDeck.AddCardToDeck(new MasterOfEvil.Whirlwind());
				break;
			case "Spider foes":
				VillainDeck.AddCardToDeck(new SpiderFoes.DoctorOctopus());
				VillainDeck.AddCardToDeck(new SpiderFoes.DoctorOctopus());
				VillainDeck.AddCardToDeck(new SpiderFoes.GreenGoblin());
				VillainDeck.AddCardToDeck(new SpiderFoes.GreenGoblin());
				VillainDeck.AddCardToDeck(new SpiderFoes.TheLizard());
				VillainDeck.AddCardToDeck(new SpiderFoes.TheLizard());
				VillainDeck.AddCardToDeck(new SpiderFoes.Venom());
				VillainDeck.AddCardToDeck(new SpiderFoes.Venom());
				break;
			case "Skrull":
				VillainDeck.AddCardToDeck(new Skrulls.PaibokThePowerSkrull());
				VillainDeck.AddCardToDeck(new Skrulls.SkrullQueenVeranke());
				VillainDeck.AddCardToDeck(new Skrulls.SkrullShapeshifter());
				VillainDeck.AddCardToDeck(new Skrulls.SkrullShapeshifter());
				VillainDeck.AddCardToDeck(new Skrulls.SkrullShapeshifter());
				VillainDeck.AddCardToDeck(new Skrulls.SuperSkrull());
				VillainDeck.AddCardToDeck(new Skrulls.SuperSkrull());
				VillainDeck.AddCardToDeck(new Skrulls.SuperSkrull());
				break;
				
			}
		}
		for ( int f = 0; f < selectedHenchmen.Count; f++)
		{
			switch (selectedHenchmen[f])
			{
			case "Sentinel":
				for(int r = 0; r<10; r++)
				{
					VillainDeck.AddCardToDeck(new Henchmen.Sentinels());
				}
				break;
			case "DoomBot Legion":
				for(int r = 0; r<10; r++)
				{
					VillainDeck.AddCardToDeck(new Henchmen.DoombotLegion());
				}
				break;
			case "Hand Ninjas":
				for(int r = 0; r<10; r++)
				{
					VillainDeck.AddCardToDeck(new Henchmen.HandNinjas());
				}
				break;
			case "Savage Land Mutates":
				for(int r = 0; r<10; r++)
				{
					VillainDeck.AddCardToDeck(new Henchmen.SavageLandMutates());
				}
				break;
			}
		}
		for ( int g = 0; g < bystanderListMax; g++)
		{
			VillainDeck.AddCardToDeck(new Bystander());
		}
		for ( int h = 0; h < 5; h++)
		{
			VillainDeck.AddCardToDeck(new MasterStrike());
		}
		for ( int i = 0; i < schemetwistCount; i++)
		{
			VillainDeck.AddCardToDeck(new SchemeTwist());
		}
		
	}

	void CreateCards()
	{
		WoundsDeck = new Deck(); 
		for(int a = 0; a < 30; a++)
		{
			WoundsDeck.AddCardToDeck(new Wound());
		}
		BystanderDeck = new Deck();
		for (int b = 0; b < 30; b++)
		{
			BystanderDeck.AddCardToDeck(new Bystander());
		}
		SHIELDDeck = new Deck();
		for (int c = 0; c < 30; c++)
		{
			SHIELDDeck.AddCardToDeck(new MariaHill());
		}
		
		Escaped     = new Deck(); 
		KO          = new Deck(); 
	}
	
	void StartGame ()
	{
		chooseVillain = false;
		selected = false;
		CreateCards();
		CreateChosenDecks();
		
		gameData.bystanderDeck = BystanderDeck;
		gameData.heroDeck = HeroDeck;
		gameData.mastermindDeck = MastermindDeck;
		gameData.shieldDeck = SHIELDDeck;
		gameData.villainDeck = VillainDeck;
		gameData.woundsDeck = WoundsDeck;
		gameData.numberOfPlayer = numberOfPlayer;
		gameData.playerNames = playerNames;
		gameData.gameMastermind = gamesMastermind;
		gameData.gameScheme = gamesScheme;
		CreatePlayers();

		Debug.Log ("START GAME");
		Application.LoadLevel("Start");
		//GOTO MainGame Screen
	}
}

