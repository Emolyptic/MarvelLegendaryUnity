using UnityEngine;
using System.Collections;

public class BlackWidow : MonoBehaviour {
	public class SilentSniper:Hero{
		public SilentSniper():base((Texture2D)Resources.Load("Textures/black_widow_silent_sniper_md")){
			Debug.Log ("sniper created");
		}
		
		public override void Ability(Player player)
		{
			Debug.Log ("sniper");
		}
		
		public override void SuperPower()
		{
		}
	}

	public class CovertOperation:Hero{
		public CovertOperation():base((Texture2D)Resources.Load("Textures/black_widow_covert_operation_3_md")){
		}
		
		public override void Ability(Player player)
		{
			Debug.Log ("covert");
		}
		
		public override void SuperPower()
		{
		}

	}

	public class DangerousRescue:Hero{
		public DangerousRescue():base((Texture2D)Resources.Load("Textures/black_widow_dangerous_rescue_5_md")){
		}
		
		public override void Ability(Player player)
		{
			Debug.Log ("rescue");
		}
		
		public override void SuperPower()
		{
		}

	}

	public class MissionAccomplished:Hero{
		public MissionAccomplished():base((Texture2D)Resources.Load("Textures/black_widow_mission_accomplished_5_md")){
		}
		
		public override void Ability(Player player)
		{
			Debug.Log ("mission");
		}
		
		public override void SuperPower()
		{
		}

	}
}
