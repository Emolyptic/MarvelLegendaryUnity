using UnityEngine;
using System.Collections;

public class Hawkeye : MonoBehaviour {
	public class ImpossibleTrickShot:Hero{
		public ImpossibleTrickShot():base((Texture2D)Resources.Load("Textures/hawkeye_impossible_trick_shot_md")){
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
	
	public class CoveringFire:Hero{
		public CoveringFire():base((Texture2D)Resources.Load("Textures/hawkeye_covering_fire_3_md")){
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
	
	public class QuickDraw:Hero{
		public QuickDraw():base((Texture2D)Resources.Load("Textures/hawkeye_quick_draw_5_md")){
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
	
	public class TeamPlayer:Hero{
		public TeamPlayer():base((Texture2D)Resources.Load("Textures/hawkeye_team_player_5_md")){
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
