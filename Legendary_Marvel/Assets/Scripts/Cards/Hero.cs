using UnityEngine;
using System.Collections;
public enum Team{ 
	Avengers, 
	Xmen, 
	Spiderfriends, 
	Shield,
	None
}
public enum Type{
	Strength,
	Instinct,
	Covert,
	Tech,
	Ranged,
	Basic
}
public class Hero : Card {
	public string name{get;set;}
	public Texture2D texture{get;set;}
	public int Cost{get;set;}
	public int Attack{get;set;}
	public int Recruit{get;set;}
	Team Team{get;set;}
	Type Type{get;set;}

	public Hero(Texture2D texture)
	{
	}

	public virtual void Ability(Player player)
	{
	}

	public virtual void SuperPower()
	{
	}
}
