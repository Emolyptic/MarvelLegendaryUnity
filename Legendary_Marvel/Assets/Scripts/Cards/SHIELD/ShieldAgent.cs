using UnityEngine;
using System.Collections;

public class ShieldAgent : Card {
	
	public ShieldAgent(Texture2D texture)
		: base(texture)
	{
		attack = 0;
		recruit = 1;
		victorypoints = 0;
	}
}
