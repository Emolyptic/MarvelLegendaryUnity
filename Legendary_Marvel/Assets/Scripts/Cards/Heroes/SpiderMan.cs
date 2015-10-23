using UnityEngine;
using System.Collections;

public class SpiderMan : MonoBehaviour {
	public class TheAmazingSpiderMan:Hero{
		public TheAmazingSpiderMan():base((Texture2D)Resources.Load("Textures/spider_man_amazing_spider_man_md")){
			//TODO:Give Type
			//TODO:Give Team
			//TODO:Give Attack
			//TODO:Give Recruit
			//TODO:Give Cost
		}
		
		public override void Ability(Player player)
		{
			
		}
		
		public override void SuperPower()
		{
		}
	}
	
	public class WebShooter:Hero{
		public WebShooter():base((Texture2D)Resources.Load("Textures/spider_man_web_shooters_3_md")){
			//TODO:Give Type
			//TODO:Give Team
			//TODO:Give Attack
			//TODO:Give Recruit
			//TODO:Give Cost
		}
		
		public override void Ability(Player player)
		{
			
		}
		
		public override void SuperPower()
		{
		}
		
	}
	
	public class GreatResponsibility:Hero{
		public GreatResponsibility():base((Texture2D)Resources.Load("Textures/spider_man_great_responsibility_5_md")){
			//TODO:Give Type
			//TODO:Give Team
			//TODO:Give Attack
			//TODO:Give Recruit
			//TODO:Give Cost
		}
		
		public override void Ability(Player player)
		{
			
		}
		
		public override void SuperPower()
		{
		}
		
	}
	
	public class AstonishingStrength:Hero{
		public AstonishingStrength():base((Texture2D)Resources.Load("Textures/spider_man_astonishing_strength_5_md")){
			//TODO:Give Type
			//TODO:Give Team
			//TODO:Give Attack
			//TODO:Give Recruit
			//TODO:Give Cost
		}
		
		public override void Ability(Player player)
		{
			
		}
		
		public override void SuperPower()
		{
		}
		
	}
}
