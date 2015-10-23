using UnityEngine;
using System.Collections;

public class SpiderFoes : MonoBehaviour {
	public class DoctorOctopus:Villain{
		public DoctorOctopus():base((Texture2D)Resources.Load("Textures/villain_spider_foes_doctor_octopus_2_md")){
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
	
	public class GreenGoblin:Villain{
		public GreenGoblin():base((Texture2D)Resources.Load("Textures/villain_spider_foes_green_goblin_2_md")){
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
	
	public class TheLizard:Villain{
		public TheLizard():base((Texture2D)Resources.Load("Textures/villain_spider_foes_the_lizard_2_md")){
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
	
	public class Venom:Villain{
		public Venom():base((Texture2D)Resources.Load("Textures/villain_spider_foes_venom_2_md")){
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
