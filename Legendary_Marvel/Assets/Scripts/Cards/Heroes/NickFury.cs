using UnityEngine;
using System.Collections;

public class NickFury : MonoBehaviour {
	public class PureFury:Hero{
		public PureFury():base((Texture2D)Resources.Load("Textures/nick_fury_pure_fury_md")){
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
	
	public class LegendaryCommander:Hero{
		public LegendaryCommander():base((Texture2D)Resources.Load("Textures/nick_fury_legendary_commander_3_md")){
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
	
	public class BattlefieldPromotion:Hero{
		public BattlefieldPromotion():base((Texture2D)Resources.Load("Textures/nick_fury_battlefield_promotion_5_md")){
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
	
	public class HighTechWeaponry:Hero{
		public HighTechWeaponry():base((Texture2D)Resources.Load("Textures/nick_fury_high_tech_weaponry_5_md")){
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
