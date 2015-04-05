using UnityEngine;
using System.Collections;

public class BlackHole : MonoBehaviour {
	public bool gameOver = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "SpecialCube") {
			gameOver = true;
			print ("GAME OVER!!!!");
		}
		Destroy (collision.gameObject);
		
	}
}
