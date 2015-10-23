using UnityEngine;
using System.Collections;

public class SchemeTwist : Card {

	public SchemeTwist():base((Texture2D)Resources.Load("Textures/scheme_twist_11_md"))
	{
		cardType = CARDTYPE.SchemeTwist;
	}
	public void Twist()
	{
	}
}
