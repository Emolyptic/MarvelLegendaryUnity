using UnityEngine;
using System.Collections;

public class MasterOfEvil : MonoBehaviour {
	public class BaronZemo:Villain{
		public BaronZemo():base((Texture2D)Resources.Load("Textures/villain_masters_baron_zemo_2_md")){
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
	
	public class Melter:Villain{
		public Melter():base((Texture2D)Resources.Load("Textures/villain_masters_melter_2_md")){
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
	
	public class Ultron:Villain{
		public Ultron():base((Texture2D)Resources.Load("Textures/villain_masters_ultron_2_md")){
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
	
	public class Whirlwind:Villain{
		public Whirlwind():base((Texture2D)Resources.Load("Textures/villain_masters_whirlwind_2_md")){
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
