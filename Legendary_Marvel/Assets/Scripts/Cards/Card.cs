using UnityEngine;
using System.Collections;

public class Card{
    
	public Texture2D texture { get; set; }
	string name;

	public Card(Texture2D texture){
		this.texture = texture;
	}

}
