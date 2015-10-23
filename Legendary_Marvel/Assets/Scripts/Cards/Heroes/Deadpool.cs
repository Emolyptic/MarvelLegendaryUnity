using UnityEngine;
using System.Collections;

public class Deadpool : MonoBehaviour {
	public class RandomActsOfUnkindness:Hero{
		public RandomActsOfUnkindness():base((Texture2D)Resources.Load("Textures/deadpool_random_unkindness_md")){
			//TODO:Give Type
			//TODO:Give Team
			//TODO:Give Attack
			//TODO:Give Recruit
			//TODO:Give Cost
		}
		
		public override void Ability(Player player)
		{
			
		}
		
		public override void SuperPower()
		{
		}
	}
	
	public class HeyCanIGetADoOver:Hero{
		public HeyCanIGetADoOver():base((Texture2D)Resources.Load("Textures/deadpool_can_doover_3_md")){
			//TODO:Give Type
			//TODO:Give Team
			//TODO:Give Attack
			//TODO:Give Recruit
			//TODO:Give Cost
		}
		
		public override void Ability(Player player)
		{
			
		}
		
		public override void SuperPower()
		{
		}
		
	}
	
	public class Oddball:Hero{
		public Oddball():base((Texture2D)Resources.Load("Textures/deadpool_oddball_5_md")){
			//TODO:Give Type
			//TODO:Give Team
			//TODO:Give Attack
			//TODO:Give Recruit
			//TODO:Give Cost
		}
		
		public override void Ability(Player player)
		{
			
		}
		
		public override void SuperPower()
		{
		}
		
	}
	
	public class HereHoldThisForASecond:Hero{
		public HereHoldThisForASecond():base((Texture2D)Resources.Load("Textures/deadpool_here_hold_this_5_md")){
			//TODO:Give Type
			//TODO:Give Team
			//TODO:Give Attack
			//TODO:Give Recruit
			//TODO:Give Cost
		}
		
		public override void Ability(Player player)
		{
			
		}
		
		public override void SuperPower()
		{
		}
		
	}
}
