using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//POSSIBLY DON"T NEED
enum VillainType{
	Henchman,
	Villain,
	Mastermind
}

public class Villain : Card {
	int Fight{get;set;}
	int VictoryPoints{get;set;}
	List<Bystander> bystanders;

	public Villain(Texture2D texture):base(texture)
	{
	}

	public virtual void FightEffect()
	{
	}

	public virtual void AmbushEffect()
	{
	}

	public virtual void EscapeEffect()
	{
		//DEFAULT KO hero from HQ
	}
}
