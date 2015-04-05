using UnityEngine;
using System.Collections;

public class BlackHole : MonoBehaviour {
	public bool gameOver = false;
	public ParticleSystem particleSys;

	// Use this for initialization
	void Start () {
		//particleSys.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "SpecialCube") {
			gameOver = true;
			print ("GAME OVER!!!!");
		}
//		if (collision.gameObject.tag != "Generating")
		particleSys.Play ();
		Destroy (collision.gameObject);
		print ("Destroyed object");
		
	}
}
