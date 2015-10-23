using UnityEngine;
using System.Collections;

public class Magneto : MonoBehaviour {
	public class BitterCaptor:Villain{
		public BitterCaptor():base((Texture2D)Resources.Load("Textures/magneto_tactic_bitter_captor_md")){
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
	
	public class CrushingShockwave:Villain{
		public CrushingShockwave():base((Texture2D)Resources.Load("Textures/magneto_tactic_crushing_shockwave_md")){
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
	
	public class ElectromagneticBubble:Villain{
		public ElectromagneticBubble():base((Texture2D)Resources.Load("Textures/magneto_tactic_electromagnetic_bubble_md")){
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
	
	public class XaviersNemesis:Villain{
		public XaviersNemesis():base((Texture2D)Resources.Load("Textures/magneto_tactic_xaviers_nemesis_md")){
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
