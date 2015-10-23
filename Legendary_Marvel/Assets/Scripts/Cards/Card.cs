using UnityEngine;
using System.Collections;

public class Card{
	public enum CARDTYPE{ 
		Hero, 
		Villain, 
		SchemeTwist, 
		MasterStrike,
		Bystander,
		Wound,
		None
	}
	public Texture2D texture { get; set; }
	public CARDTYPE cardType { get; set; }

	public Card(Texture2D texture){
		this.texture = texture;
        
	}

}
