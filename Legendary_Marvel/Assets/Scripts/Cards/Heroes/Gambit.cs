using UnityEngine;
using System.Collections;

public class Gambit : MonoBehaviour {
	public class HighStakesJackpot:Hero{
		public HighStakesJackpot():base((Texture2D)Resources.Load("Textures/gambit_high_stakes_jackpot_md")){
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
	
	public class HypnoticCharm:Hero{
		public HypnoticCharm():base((Texture2D)Resources.Load("Textures/gambit_hypnotic_charm_3_md")){
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
	
	public class CardShark:Hero{
		public CardShark():base((Texture2D)Resources.Load("Textures/gambit_card_shark_5_md")){
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
	
	public class StackTheDeck:Hero{
		public StackTheDeck():base((Texture2D)Resources.Load("Textures/gambit_stack_deck_5_md")){
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
