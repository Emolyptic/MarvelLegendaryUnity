using UnityEngine;
using System.Collections;

public class Loki : MonoBehaviour {
	public class CruelRuler:Villain{
		public CruelRuler():base((Texture2D)Resources.Load("Textures/loki_cruel_ruler_md")){
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
	
	public class ManiacalTyrant:Villain{
		public ManiacalTyrant():base((Texture2D)Resources.Load("Textures/loki_maniacal_tyrant_md")){
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
	
	public class VanishingIllusions:Villain{
		public VanishingIllusions():base((Texture2D)Resources.Load("Textures/loki_vanishing_illusions_md")){
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
	
	public class WhispersAndLies:Villain{
		public WhispersAndLies():base((Texture2D)Resources.Load("Textures/loki_whispers_lies_md")){
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
