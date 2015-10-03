using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//POSSIBLY DON"T NEED
public enum VillainType{
	Henchman,
	Villain,
	Mastermind
}

public class Villain : Card {
	public string name{get;set;}
	public Texture2D texture{get;set;}
	public int Fight{get;set;}
	public int VictoryPoints{get;set;}
	public List<Bystander> bystanders;

	public Villain(Texture2D texture)
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
