using UnityEngine;
using System.Collections;

public class Hulk : MonoBehaviour {
	public class HulkSmash:Hero{
		public HulkSmash():base((Texture2D)Resources.Load("Textures/hulk_hulk_smash_md")){
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
	
	public class CrazedRampage:Hero{
		public CrazedRampage():base((Texture2D)Resources.Load("Textures/hulk_crazed_rampage_3_md")){
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
	
	public class UnstoppableHulk:Hero{
		public UnstoppableHulk():base((Texture2D)Resources.Load("Textures/hulk_unstoppable_hulk_5_md")){
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
	
	public class GrowingAnger:Hero{
		public GrowingAnger():base((Texture2D)Resources.Load("Textures/hulk_growing_anger_5_md")){
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
