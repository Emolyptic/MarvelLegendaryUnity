using UnityEngine;
using System.Collections;

public class Wolverine : MonoBehaviour {
	public class BerserkerRage:Hero{
		public BerserkerRage():base((Texture2D)Resources.Load("Textures/wolverine_beserker_rage_md")){
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
	
	public class FrenziedSlashing:Hero{
		public FrenziedSlashing():base((Texture2D)Resources.Load("Textures/wolverine_frenzied_slashing_3_md")){
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
	
	public class HealingFactor:Hero{
		public HealingFactor():base((Texture2D)Resources.Load("Textures/wolverine_healing_factor_5_md")){
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
	
	public class KeenSenses:Hero{
		public KeenSenses():base((Texture2D)Resources.Load("Textures/wolverine_keen_senses_5_md")){
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
