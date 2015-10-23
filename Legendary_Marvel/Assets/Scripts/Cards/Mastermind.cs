using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Mastermind : Card {
	int Fight{get;set;}
	int VictoryPoints{get;set;}
	public List<Bystander> bystanders;
	public Mastermind(Texture2D texture):base(texture)
	{
		cardType = CARDTYPE.Villain;
	}
	
	public virtual void AlwaysLeads()
	{
	}

	public virtual void MasterStrike()
	{
	}
}

public class MMDrDoom: Mastermind {
	public MMDrDoom():base((Texture2D)Resources.Load("Textures/doctor_doom_mastermind_md"))
	{
	}

	public override void AlwaysLeads()
	{
		GameObject.Find("SetupObject").GetComponent<Setup>().henchmanListMax--;
		for(int i = 0; i < 10 ; i++)
		{
			//GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new Henchmen.DoombotLegion()); 
			GameObject.Find ("SetupObject").GetComponent<Setup>().selectedHenchmen.Add ("DoomBot Legion");
			GameObject.Find("SetupObject").GetComponent<Setup>().henchmenList.Remove("DoomBot Legion");
		}
	}
	
	public override void MasterStrike()
	{
	}
	
}
public class MMLoki: Mastermind {
	public MMLoki():base((Texture2D)Resources.Load("Textures/loki_mastermind_md"))
	{
	}

	public override void AlwaysLeads()
	{
		GameObject.Find("SetupObject").GetComponent<Setup>().villainListMax--;

		GameObject.Find("SetupObject").GetComponent<Setup>().selectedVillains.Add ("Enemies of Asgard");
		GameObject.Find("SetupObject").GetComponent<Setup>().villainList.Remove("Enemies of Asgard");

//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new EnemiesOfAsgard.Destroyer());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new EnemiesOfAsgard.Enchantress());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new EnemiesOfAsgard.Enchantress());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new EnemiesOfAsgard.FrostGiant());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new EnemiesOfAsgard.FrostGiant());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new EnemiesOfAsgard.FrostGiant());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new EnemiesOfAsgard.YmirFrostGiantKing());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new EnemiesOfAsgard.YmirFrostGiantKing());
	}
	
	public override void MasterStrike()
	{
	}
	
}
public class MMMagneto: Mastermind {
	public MMMagneto():base((Texture2D)Resources.Load("Textures/magneto_mastermind_md"))
	{
	}

	public override void AlwaysLeads()
	{
		GameObject.Find("SetupObject").GetComponent<Setup>().villainListMax--;

		GameObject.Find("SetupObject").GetComponent<Setup>().selectedVillains.Add ("Brotherhood");
		GameObject.Find("SetupObject").GetComponent<Setup>().villainList.Remove("Brotherhood");
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new Brotherhood.Blob());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new Brotherhood.Blob());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new Brotherhood.Juggernaut());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new Brotherhood.Juggernaut());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new Brotherhood.Mystique());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new Brotherhood.Mystique());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new Brotherhood.Sabertooth());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new Brotherhood.Sabertooth());
	}
	
	public override void MasterStrike()
	{
	}
	
}
public class MMRedSkull: Mastermind {
	public MMRedSkull():base((Texture2D)Resources.Load("Textures/red_skull_mastermind_md"))
	{
	}

	public override void AlwaysLeads()
	{
		GameObject.Find("SetupObject").GetComponent<Setup>().villainListMax--;

		GameObject.Find("SetupObject").GetComponent<Setup>().selectedVillains.Add("Hydra");
		GameObject.Find("SetupObject").GetComponent<Setup>().villainList.Remove("Hydra");
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new Hydra.EndlessArmiesofHydra());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new Hydra.EndlessArmiesofHydra());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new Hydra.EndlessArmiesofHydra());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new Hydra.HydraKidnappers());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new Hydra.HydraKidnappers());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new Hydra.HydraKidnappers());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new Hydra.SupremeHydra());
//		GameObject.Find("SetupObject").GetComponent<Setup>().VillainDeck.AddCardToDeck(new Hydra.Viper());

	}
	
	public override void MasterStrike()
	{
	}
	
}
