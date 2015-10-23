using UnityEngine;
using System.Collections;

public class Wound : Card{

	public Wound():base((Texture2D)Resources.Load("wound_30_md"))
	{
		cardType = CARDTYPE.Wound;
	}
   

}
