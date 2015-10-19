using UnityEngine;
using System.Collections;

public class Bystander : Card {
	int VictoryPoints{get;set;}

	public Bystander(Texture2D texture):base(texture)
	{
		this.attack = 0;
		this.recruit = 0;
		this.victorypoints = 1;
	}
}
