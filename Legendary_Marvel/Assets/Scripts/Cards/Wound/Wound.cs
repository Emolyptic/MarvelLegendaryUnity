using UnityEngine;
using System.Collections;

public class Wound : Card{

	public Wound(Texture2D texture):base(texture)
	{
		attack = 0;
		recruit = 0;
		victorypoints = 0;
	}
   

}
