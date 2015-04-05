using UnityEngine;
using System.Collections;

public class GameStats : MonoBehaviour {
	public int score = 0;
	public int timeLeft = 45;
	public int keysLeft = 2;
	public bool youWin = false;
	public bool youLose = false;

	public GameObject bigBlackHole;
	Collider bigCol; 

	// Use this for initialization
	void Start () {
		bigCol = bigBlackHole.GetComponent<Collider> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (keysLeft == 0) {
			youWin = true;
			//Winning screen
		} else if (timeLeft == 0) {
			youLose = true;
			//Losing screen
		}

	
	}
}
