using UnityEngine;
using System.Collections;

public class RedSkull : MonoBehaviour {
	public class EndlessResources:Villain{
		public EndlessResources():base((Texture2D)Resources.Load("Textures/red_skull_endless_resources_md")){
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
	
	public class HydraConspiracy:Villain{
		public HydraConspiracy():base((Texture2D)Resources.Load("Textures/red_skull_hydra_conspiracy_md")){
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
	
	public class NegablastGrenades:Villain{
		public NegablastGrenades():base((Texture2D)Resources.Load("Textures/red_skull_negablast_grenades_md")){
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
	
	public class RuthlessDictator:Villain{
		public RuthlessDictator():base((Texture2D)Resources.Load("Textures/red_skull_ruthless_dictator_md")){
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
