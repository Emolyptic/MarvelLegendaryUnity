using UnityEngine;
using System.Collections;

public class DrDoom : MonoBehaviour {
	public class DarkTechnology:Villain{
		public DarkTechnology():base((Texture2D)Resources.Load("Textures/doctor_doom_dark_technology_md")){
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
	
	public class MonarchsDecree:Villain{
		public MonarchsDecree():base((Texture2D)Resources.Load("Textures/doctor_doom_monarchs_decree_md")){
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
	
	public class SecretsOfTimeTravel:Villain{
		public SecretsOfTimeTravel():base((Texture2D)Resources.Load("Textures/doctor_doom_secrets_time_travel_md")){
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
	
	public class TreasuresOfLatveria:Villain{
		public TreasuresOfLatveria():base((Texture2D)Resources.Load("Textures/doctor_doom_treasures_latveria_md")){
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
