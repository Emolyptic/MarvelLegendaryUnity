using UnityEngine;
using System.Collections;

public class MainGame : MonoBehaviour {
	int phase;

	bool chooseplayer		= false;
	bool chooseheroes		= false;
	bool choosehenchmen		= false;
	bool choosevillain		= false;
	bool choosemastermind	= false;
	bool choosescheme 		= false;

	// Use this for initialization
	void Start () {
		phase = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(phase == 0) //Setup
		{	chooseplayer = true;
			SetupUpdate();
		}
		else if(phase == 1)
		{

		}
	}
	void SetupUpdate()
	{

	}
	void OnGUI()
	{
		if(phase = 0)
		{
			if(chooseplayer)
			{
				if(GUI.Button(new Rect(0,0,50,50),"Next"))
				{
					chooseheroes = true;
					choosplayer = false;
				}
			}
			if(chooseheroes)
			{
				if(GUI.Button(new Rect(0,0,50,50),"Next"))
				{
					choosehenchmen = true;
					chooseheroes = false;
				}
			}
			if(choosehenchmen)
			{
				if(GUI.Button(new Rect(0,0,50,50),"Next"))
				{
					choosevillain = true;
					choosehenchmen = false;
				}
			}
			if(choosevillain)
			{
				if(GUI.Button(new Rect(0,0,50,50),"Next"))
				{
					choosemastermind = true;
					choosevillain = false;
				}
			}
			if(choosemastermind)
			{
				if(GUI.Button(new Rect(0,0,50,50),"Next"))
				{
					choosescheme = true;
					choosemastermind = false;
				}
			}
			if(choosescheme)
			{
				if(GUI.Button(new Rect(0,0,50,50)," Next"))
				{
					choosescheme = false;
				}
			}
		}
	}
}
