using UnityEngine;
using System.Collections;

public class Henchmen : MonoBehaviour {
	public class DoombotLegion:Villain{
		public DoombotLegion():base((Texture2D)Resources.Load("Textures/henchmen_doombot_legion_10_md")){
			//int Fight{get;set;}
			//int VictoryPoints{get;set;}
			//List<Bystander> bystanders;
		}
		public override void FightEffect()
		{
		}
		
		public override void AmbushEffect()
		{
		}
		
		public override void EscapeEffect()
		{
			//DEFAULT KO hero from HQ
		}
	}
	
	public class HandNinjas:Villain{
		public HandNinjas():base((Texture2D)Resources.Load("Textures/henchmen_hand_ninjas_10_md")){
			//int Fight{get;set;}
			//int VictoryPoints{get;set;}
			//List<Bystander> bystanders;
		}
		
		public override void FightEffect()
		{
		}
		
		public override void AmbushEffect()
		{
		}
		
		public override void EscapeEffect()
		{
			//DEFAULT KO hero from HQ
		}
		
	}
	
	public class SavageLandMutates:Villain{
		public SavageLandMutates():base((Texture2D)Resources.Load("Textures/henchmen_savage_land_mutants_10_md")){
			//int Fight{get;set;}
			//int VictoryPoints{get;set;}
			//List<Bystander> bystanders;
		}
		
		public override void FightEffect()
		{
		}
		
		public override void AmbushEffect()
		{
		}
		
		public override void EscapeEffect()
		{
			//DEFAULT KO hero from HQ
		}
		
	}
	
	public class Sentinels:Villain{
		public Sentinels():base((Texture2D)Resources.Load("Textures/henchman_sentinel_10_med")){
			//int Fight{get;set;}
			//int VictoryPoints{get;set;}
			//List<Bystander> bystanders;
		}
		
		public override void FightEffect()
		{
		}
		
		public override void AmbushEffect()
		{
		}
		
		public override void EscapeEffect()
		{
			//DEFAULT KO hero from HQ
		}
		
	}
}
