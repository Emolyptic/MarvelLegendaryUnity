using UnityEngine;
using System.Collections;
enum Team{ 
	Avengers, 
	Xmen, 
	Spiderfriends, 
	Shield,
	None
}
enum Type{
	Strength,
	Instinct,
	Covert,
	Tech,
	Ranged,
	Basic
}
public class Hero : Card {
	public int Cost{get;set;}
	public int Attack{get;set;}
	public int Recruit{get;set;}
	Team Team{get;set;}
	Type Type{get;set;}

	public Hero(Texture2D texture):base(texture)
	{
		cardType = CARDTYPE.Hero;
	}

	public virtual void Ability(Player player)
	{
	}

	public virtual void SuperPower()
	{
	}
}
