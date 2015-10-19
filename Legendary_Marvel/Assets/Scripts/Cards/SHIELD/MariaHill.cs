using UnityEngine;
using System.Collections;

public class MariaHill : Card
{
    public MariaHill(Texture2D texture) : base(texture)
    {
		attack = 0;
		recruit = 2;
		victorypoints = 0;
    }
}
