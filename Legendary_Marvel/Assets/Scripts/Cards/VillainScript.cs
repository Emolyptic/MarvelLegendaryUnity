using UnityEngine;
using System.Collections;

public class VillainScript : MonoBehaviour {
	public Villain card;
	public bool isMastermind;
	public DataManager gameData;
	public MainGame mainGame;
	public CardManager cardManager;
	
	// Use this for initialization
	void Start () {
		mainGame = GameObject.Find("RunGameObject").GetComponent<MainGame>();
		cardManager = GameObject.Find("RunGameObject").GetComponent<CardManager>();
		gameData = GameObject.Find("GameData").GetComponent<DataManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		//Check if there is enough attack to attack this villian
		//Attack effect
		//Destroy card.
		//Take Texture off Card
		//add victorypoints to player
		//check for bystanders

	}
}
