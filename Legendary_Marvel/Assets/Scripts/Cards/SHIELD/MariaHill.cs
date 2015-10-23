using UnityEngine;
using System.Collections;

public class MariaHill : Hero
{
	public MariaHill() : base((Texture2D)Resources.Load("Textures/shield_officer_maria_hill_30_md"))
    {
		Attack = 0;
		Recruit = 2;
    }
}
