using UnityEngine;
using System.Collections;

public class Rogue : MonoBehaviour {
	public class StealAbilities:Hero{
		public StealAbilities():base((Texture2D)Resources.Load("Textures/rogue_steal_abilities_md")){
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
	
	public class CopyPowers:Hero{
		public CopyPowers():base((Texture2D)Resources.Load("Textures/rogue_copy_powers_3_md")){
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
	
	public class BorrowedBrawn:Hero{
		public BorrowedBrawn():base((Texture2D)Resources.Load("Textures/rogue_borrowed_brawn_5_md")){
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
	
	public class EnergyDrain:Hero{
		public EnergyDrain():base((Texture2D)Resources.Load("Textures/rogue_energy_drain_5_md")){
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
