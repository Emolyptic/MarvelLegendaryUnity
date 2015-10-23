using UnityEngine;
using System.Collections;

public class CaptainAmerica : MonoBehaviour {
	public class ADayUnlikeAnyOther:Hero{
		public ADayUnlikeAnyOther():base((Texture2D)Resources.Load("Textures/captain_america_day_any_other_md")){
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
	
	public class DivingBlocks:Hero{
		public DivingBlocks():base((Texture2D)Resources.Load("Textures/captain_america_diving_block_3_md")){
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
	
	public class AvengersAssemble:Hero{
		public AvengersAssemble():base((Texture2D)Resources.Load("Textures/captain_america_avengers_assemble_5_md")){
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
	
	public class PerfectTeamwork:Hero{
		public PerfectTeamwork():base((Texture2D)Resources.Load("Textures/captain_america_perfect_teamwork_5_md")){
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
