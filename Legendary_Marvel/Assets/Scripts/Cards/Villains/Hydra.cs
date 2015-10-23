using UnityEngine;
using System.Collections;

public class Hydra : MonoBehaviour {
	public class EndlessArmiesofHydra:Villain{
		public EndlessArmiesofHydra():base((Texture2D)Resources.Load("Textures/villain_hydra_endless_armies_hydra_3_md")){
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
	
	public class HydraKidnappers:Villain{
		public HydraKidnappers():base((Texture2D)Resources.Load("Textures/villain_hydra_kidnappers_3_md")){
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
	
	public class SupremeHydra:Villain{
		public SupremeHydra():base((Texture2D)Resources.Load("Textures/villain_hydra_supreme_hydra_md")){
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
	
	public class Viper:Villain{
		public Viper():base((Texture2D)Resources.Load("Textures/villain_hydra_viper_md")){
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
