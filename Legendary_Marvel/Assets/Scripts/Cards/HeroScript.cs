using UnityEngine;
using System.Collections;

public class HeroScript : MonoBehaviour {

	private Hero hero;
	public Hero Hero{ get{ return hero; } set{hero = value;}}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		this.hero.Ability(new Player());
	}
}
