using UnityEngine;
using System.Collections;

public class Bystander : Card {
	int VictoryPoints{get;set;}

	public Bystander():base((Texture2D)Resources.Load("Textures/bystander_30_md"))
	{
		cardType = CARDTYPE.Bystander;
	}
}
