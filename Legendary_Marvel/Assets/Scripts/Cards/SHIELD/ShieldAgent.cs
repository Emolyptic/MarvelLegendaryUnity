using UnityEngine;
using System.Collections;

public class ShieldAgent : Hero {
	
	public ShieldAgent(): base((Texture2D)Resources.Load("Textures/shield_agent_40_md"))
	{
		Attack = 0;
		Recruit = 1;
	}
}
