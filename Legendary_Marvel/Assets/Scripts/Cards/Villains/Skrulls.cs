using UnityEngine;
using System.Collections;

public class Skrulls : MonoBehaviour {
	public class PaibokThePowerSkrull:Villain{
		public PaibokThePowerSkrull():base((Texture2D)Resources.Load("Textures/villain_skrull_power_skrull_md")){
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
	
	public class SkrullQueenVeranke:Villain{
		public SkrullQueenVeranke():base((Texture2D)Resources.Load("Textures/villain_skrull_queen_veranke_md")){
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
	
	public class SkrullShapeshifter:Villain{
		public SkrullShapeshifter():base((Texture2D)Resources.Load("Textures/villain_skrull_shapeshifters_3_md")){
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
	
	public class SuperSkrull:Villain{
		public SuperSkrull():base((Texture2D)Resources.Load("Textures/villain_skrull_super_skrull_3_md")){
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
