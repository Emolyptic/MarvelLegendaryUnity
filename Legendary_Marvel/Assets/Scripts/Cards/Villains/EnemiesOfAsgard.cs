using UnityEngine;
using System.Collections;

public class EnemiesOfAsgard : MonoBehaviour {
	public class Destroyer:Villain{
		public Destroyer():base((Texture2D)Resources.Load("Textures/villain_asgard_destroyer_md")){
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
	
	public class Enchantress:Villain{
		public Enchantress():base((Texture2D)Resources.Load("Textures/villain_asgard_enchantress_2_md")){
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
	
	public class FrostGiant:Villain{
		public FrostGiant():base((Texture2D)Resources.Load("Textures/villain_asgard_frost_giant_3_md")){
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
	
	public class YmirFrostGiantKing:Villain{
		public YmirFrostGiantKing():base((Texture2D)Resources.Load("Textures/villain_asgard_ymir_2_md")){
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
