using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MainGame : MonoBehaviour {
	int phase;
	//public GameObject cardObject;

    # region Decks
    Deck VillianDeck;
    Deck HeroDeck;
    Deck MastermindDeck;
    Deck WoundsDeck;
    Deck BystanderDeck;
    Deck SHIELDDeck;
    Deck Escaped;
    Deck KO;
    #endregion

    #region phase 0 miniphase bools
    bool choosePlayer		= false;
	bool chooseHeroes		= false;
	bool chooseHenchmen		= false;
	bool chooseVillain		= false;
	bool chooseMastermind	= false;
	bool chooseScheme 		= false;
	bool selected  			= false;
	#endregion

	#region Saved Data
	int numberOfPlayer;
	List<string> heroDeckList = new List<string>(){"","","","",""};
	List<string> selectedHenchmen;
	List<string> selectedVillians;
	//List<string> shieldDeck;
	//List<string> woundDeck;
	//List<string> bystanderDeck;

	string selectedMastermind;
	string selectedScheme;
	int schemetwistCount;
	#endregion

	#region TODO Replace these with the Dictionaries of Objects
	List<string> heroes = new List<string>(){
		"Black Widow",
		"Captain America",
		"Cyclops",
		"Deadpool",
		"Emma Frost",
		"Gambit",
		"Hawk Eye",
		"Hulk",
		"Iron Man",
		"Nick Fury",
		"Rouge",
		"Spiderman",
		"Storm",
		"Thor",
		"Wolverine"
	};

	List<string> henchmen = new List<string>(){
		"Sentinel",
		"DoomBot Legion",
		"Hand Ninjas",
		"Savage Land Mutates"
	};

	List<string> villian = new List<string>(){
		"Brotherhood",
		"Hydra",
		"Masters of Evil",
		"Spider foes",
		"Skrull"
	};

	List<string> mastermind = new List<string>(){
		"Red Skull",
		"Loki",
		"Magneto",
		"Doctor Doom"
	};

	List<string> scheme = new List<string>(){
		"Pull Reality into the Negative Zone",
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
	
	float playerButtonXPos 		= screenWidth * .1f;
	float playerButtonYPos 		= screenHeight* .1f;
	float playerButtonWidth 	= screenWidth * .18f;
	float playerButtonHeight 	= screenHeight* .1f;

	float heroButtonXPos 	= screenWidth * .1f;
	float heroButtonYPos 	= screenHeight* .1f;
	float heroButtonWidth	= screenWidth * .18f;
	float heroButtonHeight 	= screenHeight* .1f;

	float cardIconXPos 	= screenWidth * .9f;
	float cardIconYPos 	= screenHeight* .1f;
	float cardIconWidth	= screenWidth * .18f;
	float cardIconHeight = screenHeight* .1f;

	float henchmenButtonXPos 	= screenWidth * .1f;
	float henchmenButtonYPos 	= screenHeight* .1f;
	float henchmenButtonWidth	= screenWidth * .18f;
	float henchmenButtonHeight 	= screenHeight* .1f;

	float villianButtonXPos 	= screenWidth * .1f;
	float villianButtonYPos 	= screenHeight* .1f;
	float villianButtonWidth	= screenWidth * .18f;
	float villianButtonHeight 	= screenHeight* .1f;

	float mastermindButtonXPos 	= screenWidth * .1f;
	float mastermindButtonYPos 	= screenHeight* .1f;
	float mastermindButtonWidth	= screenWidth * .18f;
	float mastermindButtonHeight= screenHeight* .1f;

	float schemeButtonXPos 	= screenWidth * .1f;
	float schemeButtonYPos 	= screenHeight* .1f;
	float schemeButtonWidth	= screenWidth * .18f;
	float schemeButtonHeight= screenHeight* .1f;
	#endregion

	//Temps for Hero selection
	int heroListPointer = 0;
	int heroListMax = 5; //Default

	int villainListPointer = 0;
	int villainListMax = 0;

	int henchmanListPointer = 0;
	int henchmanListMax = 0;
	int bystanderListMax = 0;


	// Use this for initialization
	void Start () {
		phase = 0;
		choosePlayer = true;
		//GameObject cardPrefab = (GameObject) Instantiate(cardObject);
		//HeroScript script = cardPrefab.AddComponent<HeroScript>();
		//script.Hero =  new BlackWidow.SilentSniper ();
		//SpriteRenderer renderer = cardPrefab.GetComponent<SpriteRenderer> ();
		//renderer.sprite = Sprite.Create(script.Hero.texture,new Rect(10.0f, 10.0f, 10.0f, 10.0f),new Vector2(0.0f, 0.0f));
	}
	
	// Update is called once per frame
	void Update () {
        switch (phase)
        {
            case 0:
                SetupUpdate();
                break;
            case 1:
                break;
            default:
                break;
        }
	}
	void SetupUpdate()
	{

	}
	void OnGUI()
	{
        switch(phase)
		{
            case 0:
			#region Phase 0 Setup

			#region Choose Player Amount
			if(choosePlayer)
			{
				for(int i = 0; i < 5; i++)
				{	
					if(GUI.Button(new Rect(playerButtonXPos,playerButtonYPos+(playerButtonHeight*1.2f*i) ,playerButtonWidth, playerButtonHeight),(i+1).ToString() + " Players"))
					{
						numberOfPlayer = i;
						selected = true;
					}
				}
				if(selected)
				{
					if(GUI.Button(new Rect(screenWidth*.9f,screenHeight*.9f,screenWidth * .1f,screenHeight * .1f),"Next"))
					{
						chooseHeroes = true;
						choosePlayer = false;
						selected = false;
						switch(numberOfPlayer)
						{
						case 1:
							villainListMax = 2;
							selectedVillians = new List<string>(){"",""};

							henchmanListMax = 1;
							selectedHenchmen = new List<string>(){""};

							bystanderListMax = 2;
							break;
						case 2:
							villainListMax = 2;
							selectedVillians = new List<string>(){"",""};

							henchmanListMax = 1;
							selectedHenchmen = new List<string>(){""};

							bystanderListMax = 2;
							break;
						case 3:
							villainListMax = 3;
							selectedVillians = new List<string>(){"","",""};

							henchmanListMax = 1;
							selectedHenchmen = new List<string>(){""};

							bystanderListMax = 8;
							break;
						case 4:
							villainListMax = 3;
							selectedVillians = new List<string>(){"","",""};

							henchmanListMax = 2;
							selectedHenchmen = new List<string>(){"",""};

							bystanderListMax = 8;
							break;
						case 5:
							villainListMax = 4;
							selectedVillians = new List<string>(){"","","",""};

							henchmanListMax = 2;
							selectedHenchmen = new List<string>(){"",""};

							bystanderListMax = 12;
							break;
						}
					}
				}
			}
			#endregion
			#region ChooseHero
			//CHOOSE HERO PHASE
			if(chooseHeroes)
			{
				for(int j = 0; j < heroes.Count/2; j++)
				{
					if(GUI.Button(new Rect(heroButtonXPos,heroButtonYPos+(heroButtonHeight*1.2f*j) ,heroButtonWidth, heroButtonHeight),heroes[j] ))
					{
						addHeroToSelectedList(heroes[j]);
					}
				}
				//For column positioning
				int w = 0;
				for(int k = heroes.Count/2; k < heroes.Count; k++)
				{
					if(GUI.Button(new Rect(heroButtonXPos + (heroButtonWidth * 2),heroButtonYPos+(heroButtonHeight*1.2f*w) ,heroButtonWidth, heroButtonHeight),heroes[k] ))
					{
						addHeroToSelectedList(heroes[k]);
					}
					w++;
				}
				//Shows Icons
				for(int y = 0; y < heroDeckList.Count; y++)
				{
					if(GUI.Button(new Rect(cardIconXPos,cardIconYPos + (cardIconHeight*1.2f * y) ,cardIconWidth, cardIconHeight), heroDeckList[y]))
					{

					}
				}

				if(selected)
				{
					if(GUI.Button(new Rect(screenWidth*.9f,screenHeight*.9f,screenWidth * .1f,screenHeight * .1f),"Next"))
					{
						chooseHenchmen = true;
						chooseHeroes = false;
						selected = false;
					}
				}
			}
			#endregion
			#region ChooseHenchmen
			//CHOOSE HENCHMEN PHASE
			if(chooseHenchmen)
			{

				for(int j = 0; j < henchmen.Count/2; j++)
				{
					if(GUI.Button(new Rect(henchmenButtonXPos,henchmenButtonYPos+(henchmenButtonHeight*1.2f*j) ,henchmenButtonWidth, henchmenButtonHeight),henchmen[j] ))
					{
						addHenchmenToSelectedList(henchmen[j]);
					}
				}
				//For column positioning
				int w = 0;
				for(int k = henchmen.Count/2; k < henchmen.Count; k++)
				{
					if(GUI.Button(new Rect(henchmenButtonXPos + (henchmenButtonWidth * 2),henchmenButtonYPos+(henchmenButtonHeight*1.2f*w) ,henchmenButtonWidth, henchmenButtonHeight),henchmen[k] ))
					{
						addHenchmenToSelectedList(henchmen[k]);
					}
					w++;
				}
				//Shows Icons
				for(int y = 0; y < selectedHenchmen.Count; y++)
				{
					if(GUI.Button(new Rect(cardIconXPos,cardIconYPos + (cardIconHeight*1.2f * y) ,cardIconWidth, cardIconHeight), selectedHenchmen[y]))
					{
						
					}
				}
				if(selected)
				{
					if(GUI.Button(new Rect(screenWidth*.9f,screenHeight*.9f,screenWidth * .1f,screenHeight * .1f),"Next"))
					{
						chooseVillain = true;
						chooseHenchmen = false;
						selected = false;
					}
				}
			}
			#endregion
			#region ChooseVillain
			//CHOOSE VILLAIN PHASE
			if(chooseVillain)
			{
				for(int j = 0; j < villian.Count/2; j++)
				{
					if(GUI.Button(new Rect(villianButtonXPos,villianButtonYPos+(villianButtonHeight*1.2f*j) ,villianButtonWidth, villianButtonHeight),villian[j] ))
					{
						addVillianToSelectedList(villian[j]);
					}
				}
				//For column positioning
				int w = 0;
				for(int k = villian.Count/2; k < villian.Count; k++)
				{
					if(GUI.Button(new Rect(villianButtonXPos + (villianButtonWidth * 2),villianButtonYPos+(villianButtonHeight*1.2f*w) ,villianButtonWidth, villianButtonHeight),villian[k] ))
					{
						addVillianToSelectedList(villian[k]);
					}
					w++;
				}
				//Shows Icons
				for(int y = 0; y < selectedVillians.Count; y++)
				{
					if(GUI.Button(new Rect(cardIconXPos,cardIconYPos + (cardIconHeight*1.2f * y) ,cardIconWidth, cardIconHeight), selectedVillians[y]))
					{
						
					}
				}
				if(selected)
				{
					if(GUI.Button(new Rect(screenWidth*.9f,screenHeight*.9f,screenWidth * .1f,screenHeight * .1f),"Next"))
					{
						chooseMastermind = true;
						chooseVillain = false;
						selected = false;
					}
				}
			}
			#endregion
			#region ChooseMastermind
			//CHOOSE MASTERMIND!
			if(chooseMastermind)
			{
				for(int j = 0; j < mastermind.Count/2; j++)
				{
					if(GUI.Button(new Rect(mastermindButtonXPos,mastermindButtonYPos+(mastermindButtonHeight*1.2f*j) ,mastermindButtonWidth, mastermindButtonHeight),mastermind[j] ))
					{
						selectedMastermind = mastermind[j];
						selected = true;
					}
				}
				//For column positioning
				int w = 0;
				for(int k = mastermind.Count/2; k < mastermind.Count; k++)
				{
					if(GUI.Button(new Rect(mastermindButtonXPos + (mastermindButtonWidth * 2),mastermindButtonYPos+(mastermindButtonHeight*1.2f*w) ,mastermindButtonWidth, mastermindButtonHeight),mastermind[k] ))
					{
						selectedMastermind = mastermind[k];
						selected = true;
					}
					w++;
				}
				//Shows Icons
					if(GUI.Button(new Rect(cardIconXPos,cardIconYPos + (cardIconHeight*1.2f) ,cardIconWidth, cardIconHeight), selectedMastermind))
					{
						
					}
				if(selected)
				{
					if(GUI.Button(new Rect(screenWidth*.9f,screenHeight*.9f,screenWidth * .1f,screenHeight * .1f),"Next"))
					{
						chooseScheme = true;
						chooseMastermind = false;
						selected = false;
					}
				}
			}
			#endregion
			#region ChooseScheme
			//CHOOSE SCHEME
			if(chooseScheme)
			{
				for(int j = 0; j < scheme.Count/2; j++)
				{
					if(GUI.Button(new Rect(schemeButtonXPos,schemeButtonYPos+(schemeButtonHeight*1.2f*j) ,schemeButtonWidth, schemeButtonHeight),scheme[j] ))
					{
						selectedScheme = scheme[j];
						selected = true;
					}
				}
				//For column positioning
				int w = 0;
				for(int k = scheme.Count/2; k < scheme.Count; k++)
				{
					if(GUI.Button(new Rect(schemeButtonXPos + (schemeButtonWidth * 2),schemeButtonYPos+(schemeButtonHeight*1.2f*w) ,schemeButtonWidth, schemeButtonHeight),scheme[k] ))
					{
						selectedScheme = scheme[k];
						selected = true;
					}
					w++;
				}
				//Shows Icons
				if(GUI.Button(new Rect(cardIconXPos,cardIconYPos + (cardIconHeight*1.2f) ,cardIconWidth, cardIconHeight), selectedScheme))
				{
					
				}
				if(selected)
				{
					if(GUI.Button(new Rect(screenWidth*.9f,screenHeight*.9f,screenWidth * .1f,screenHeight * .1f),"Next"))
					{
						chooseScheme = false;
						selected = false;
                        CreateCards();
                        CreateChosenDecks();
                        phase = 1;
					}
				}
			}
			#endregion
			#endregion
            break;
            case 1:
            break;
            default:
            break;
		}
	}

    void CreateChosenDecks()
    {
        VillianDeck     = new Deck();
        CreateVillianDeck();

        HeroDeck        = new Deck();
        CreateHeroDeck();

        MastermindDeck  = new Deck();
        CreateMastermindDeck();
    }

    void CreateMastermindDeck()
    {
        for (int c = 0; c < 4; c++)
        {
            
        }
    }

    void CreateHeroDeck()
    {
        for(int d = 0; d < heroDeckList.Count; d++)
        {
			//TODO INSERT HERO CARDS
        }
    }

    void CreateVillianDeck()
    {
		for (int e = 0; e < selectedVillians.Count; e++)
        {
			//TODO INSERT VILLIANS
        }
		for ( int f = 0; f < selectedHenchmen.Count; f++)
		{
			//TODO INSERT HENCHMEN
		}
		for ( int g = 0; g < bystanderListMax; g++)
		{
			//TODO INSERT BYSTANDERS
		}
		for ( int h = 0; h < 5; h++)
		{
			//TODO INSERT MASTER STRIKE
		}
		for ( int i = 0; i < 4; i++)
		{
			//TODO INSERT SCHEME TWISTS
		}

    }
	void CreateCards()
	{
        WoundsDeck = new Deck(); 
            for(int a = 0; a < 30; a++)
            {
                WoundsDeck.AddCardToDeck(new Wound((Texture2D)Resources.Load("Textures/wound_30_md")));
		}
        BystanderDeck = new Deck();
            for (int b = 0; b < 30; b++)
            {
                BystanderDeck.AddCardToDeck(new Bystander((Texture2D)Resources.Load("Textures/bystander_30_md")));
            }
        SHIELDDeck = new Deck();
            for (int c = 0; c < 30; c++)
            {
                SHIELDDeck.AddCardToDeck(new MariaHill((Texture2D)Resources.Load("Textures/shield_officer_maria_hill_30_md")));
            }
        Escaped     = new Deck(); 
        KO          = new Deck(); 
	}

	void addHeroToSelectedList(string chosenHero)
	{
		if(!heroDeckList.Contains(chosenHero))
		{
			heroDeckList[heroListPointer] = chosenHero; 
			heroListPointer++;
			if(heroListPointer == heroListMax)
			{
				heroListPointer = 0;
				selected = true;
			}
		}

	}

	void addHenchmenToSelectedList(string chosenHenchman)
	{
		if(!selectedHenchmen.Contains(chosenHenchman))
		{
			selectedHenchmen[henchmanListPointer] = chosenHenchman; 
			henchmanListPointer++;
			if(henchmanListPointer == henchmanListMax)
			{
				henchmanListPointer = 0;
				selected = true;
			}
		}
		
	}

	void addVillianToSelectedList(string chosenVillian)
	{
		if(!selectedVillians.Contains(chosenVillian))
		{
			selectedVillians[villainListPointer] = chosenVillian; 
			villainListPointer++;
			if(villainListPointer == villainListMax)
			{
				villainListPointer = 0;
				selected = true;
			}
		}
		
	}

}
	
