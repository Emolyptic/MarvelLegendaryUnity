using UnityEngine;
using System.Collections;

public class ShieldTrooper : Card {
	
	public ShieldTrooper(Texture2D texture)
		: base(texture)
	{
		attack = 1;
		recruit = 0;
		victorypoints = 0;
	}
}
