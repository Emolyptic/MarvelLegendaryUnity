using UnityEngine;
using System.Collections;

public class ShieldTrooper : Hero {
	
	public ShieldTrooper(): base((Texture2D)Resources.Load("Textures/shield_trooper_20_md"))
	{
		Attack = 1;
		Recruit = 0;
	}
}
