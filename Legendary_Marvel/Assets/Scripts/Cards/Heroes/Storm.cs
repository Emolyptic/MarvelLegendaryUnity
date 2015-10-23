using UnityEngine;
using System.Collections;

public class Storm : MonoBehaviour {
	public class TidalWave:Hero{
		public TidalWave():base((Texture2D)Resources.Load("Textures/storm_tidal_wave_md")){
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
	
	public class SpinningCyclone:Hero{
		public SpinningCyclone():base((Texture2D)Resources.Load("Textures/storm_spinning_cyclone_3_md")){
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
	
	public class LightningBolt:Hero{
		public LightningBolt():base((Texture2D)Resources.Load("Textures/storm_lightning_bolt_5_md")){
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
	
	public class GatheringStormClouds:Hero{
		public GatheringStormClouds():base((Texture2D)Resources.Load("Textures/storm_gathering_stormclouds_5_md")){
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
