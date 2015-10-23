using UnityEngine;
using System.Collections;

public class Schemes : Card {
	public Schemes(Texture2D texture):base(texture)
	{
	}

	//Used during startup phase
	public virtual void PreSetup()
	{
	}

	public virtual void PostSetup()
	{
	}

	public virtual void Twist(int numberOfTwists)
	{
	}

	//
	public virtual void SpecialRules()
	{
	}
}

public class TheLegacyVirus: Schemes {
	public TheLegacyVirus():base((Texture2D)Resources.Load("Textures/scheme_legacy_virus_md"))
	{
	}
	public override void PreSetup()
	{
		GameObject.Find("SetupObject").GetComponent<Setup>().schemetwistCount = 8;
		// 8 Twists
		// Wound stack holds 6 Wounds per player
	}

	public override void PostSetup()
	{
	}

	public override void Twist(int numberOfTwists)
	{
	}
	
	public override void SpecialRules()
	{
	}

}

public class MidtownBankRobbery: Schemes {
	public MidtownBankRobbery():base((Texture2D)Resources.Load("Textures/scheme_midtown_bank_robbery_md"))
	{
	}
	public override void PreSetup()
	{
		GameObject.Find("SetupObject").GetComponent<Setup>().schemetwistCount = 8;
		GameObject.Find("SetupObject").GetComponent<Setup>().bystanderListMax = 12;
		//8 twists
		//12 Bystanders
	}

	public override void PostSetup()
	{
	}

	public override void Twist(int numberOfTwists)
	{
	}
	
	public override void SpecialRules()
	{
	}
	
}
public class NegativeZonePrisonBreakout: Schemes {
	public NegativeZonePrisonBreakout():base((Texture2D)Resources.Load("Textures/scheme_negative_zone_prison_breakout_md"))
	{
	}
	public override void PreSetup()
	{
		GameObject.Find("SetupObject").GetComponent<Setup>().schemetwistCount = 8;
		GameObject.Find("SetupObject").GetComponent<Setup>().henchmanListMax++; //TODO This breaks something? 
		//8 Twists
		//Henchman group +1
	}

	public override void PostSetup()
	{
	}

	public override void Twist(int numberOfTwists)
	{
	}
	
	public override void SpecialRules()
	{
	}
	
}
public class PortalsToTheDarkDimension: Schemes {
	public PortalsToTheDarkDimension():base((Texture2D)Resources.Load("Textures/scheme_portals_dark_dimension_md"))
	{
	}
	public override void PreSetup()
	{
		GameObject.Find("SetupObject").GetComponent<Setup>().schemetwistCount = 7;
		//7 Twists
	}

	public override void PostSetup()
	{
	}

	public override void Twist(int numberOfTwists)
	{
	}
	
	public override void SpecialRules()
	{
	}
	
}
public class ReplaceEarthsLeaderswithKillbots: Schemes {
	public ReplaceEarthsLeaderswithKillbots():base((Texture2D)Resources.Load("Textures/scheme_replace_leaders_killbots_md"))
	{
	}
	public override void PreSetup()
	{
		GameObject.Find("SetupObject").GetComponent<Setup>().schemetwistCount= 5;
		GameObject.Find("SetupObject").GetComponent<Setup>().bystanderListMax = 18;
		//5 twists
		//18 bystanders
		//Need special rules for this sceme with killbots
	}

	public override void PostSetup()
	{
	}

	public override void Twist(int numberOfTwists)
	{
	}
	
	public override void SpecialRules()
	{
	}
	
}
public class SecretInvasionoftheSkrullShapeshifters: Schemes {
	public SecretInvasionoftheSkrullShapeshifters():base((Texture2D)Resources.Load("Textures/scheme_secret_invasion_shapeshifters_md"))
	{
	}
	public override void PreSetup()
	{
		GameObject.Find("SetupObject").GetComponent<Setup>().schemetwistCount = 8;
		//8 Twists
		//One villain group must be skrulls
		//Grab 12 Random Heroes into the villain deck

	}

	public override void PostSetup()
	{
	}
	
	public override void Twist(int numberOfTwists)
	{
	}
	
	public override void SpecialRules()
	{
	}
	
}
public class SuperHeroCivilWar: Schemes {
	public SuperHeroCivilWar():base((Texture2D)Resources.Load("Textures/scheme_super_hero_civil_war_md"))
	{
	}
	public override void PreSetup()
	{
		if(GameObject.Find("SetupObject").GetComponent<Setup>().numberOfPlayer <=3)
		{
			GameObject.Find("SetupObject").GetComponent<Setup>().schemetwistCount = 8;
		}
		else 
		{
			GameObject.Find("SetupObject").GetComponent<Setup>().schemetwistCount = 5;
		}
		//for 2-3 players, use 8 twists for 4-5 players use 5 twists
		//if only 2 players use only 4 heroes in the Hero deck.
	}

	public override void PostSetup()
	{
	}
	
	public override void Twist(int numberOfTwists)
	{
	}
	
	public override void SpecialRules()
	{
	}
	
}
public class UnleashthePoweroftheCosmicCube: Schemes {
	public UnleashthePoweroftheCosmicCube():base((Texture2D)Resources.Load("Textures/scheme_unleash_cosmic_cube_md"))
	{
	}
	public override void PreSetup()
	{
		GameObject.Find("SetupObject").GetComponent<Setup>().schemetwistCount = 8;
	}

	public override void PostSetup()
	{
	} 

	public override void Twist(int numberOfTwists)
	{
	}
	
	public override void SpecialRules()
	{
	}
	
}