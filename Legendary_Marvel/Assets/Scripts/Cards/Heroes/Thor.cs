using UnityEngine;
using System.Collections;

public class Thor : MonoBehaviour {
	public class GodOfThunder:Hero{
		public GodOfThunder():base((Texture2D)Resources.Load("Textures/thor_god_of_thunder_md")){
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
	
	public class CallLightning:Hero{
		public CallLightning():base((Texture2D)Resources.Load("Textures/thor_call_lightning_3_md")){
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
	
	public class SurgeOfPower:Hero{
		public SurgeOfPower():base((Texture2D)Resources.Load("Textures/thor_surge_power_5_md")){
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
	
	public class Odinson:Hero{
		public Odinson():base((Texture2D)Resources.Load("Textures/thor_odinson_5_md")){
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
