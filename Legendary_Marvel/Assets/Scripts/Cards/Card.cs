using UnityEngine;
using System.Collections;

public class Card{
    
	public Texture2D texture { get; set; }
	public int recruit { get; set; }
	public int attack { get; set; }
	public int victorypoints { get; set; }

	public Card(Texture2D texture){
		this.texture = texture;
        
	}

}
