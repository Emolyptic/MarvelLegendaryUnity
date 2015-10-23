using UnityEngine;
using System.Collections;

public class MasterStrike : Card {

	public MasterStrike():base((Texture2D)Resources.Load("Textures/master_strike_5_md"))
	{
		cardType = CARDTYPE.MasterStrike;
	}
	public void Strike()
	{
	}
}
