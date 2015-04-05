using UnityEngine;
using System.Collections;

public class BlackHole : MonoBehaviour {
	public bool gameOver = false;
	public ParticleSystem particleSys;
	public GameObject gameStats;

	private AudioSource audsource;
	public AudioClip BlackholeSuck;

	// Use this for initialization
	void Start () {
		//particleSys.gameObject.SetActive (false);
		audsource = GetComponent<AudioSource> ();
		audsource.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "SpecialCube") {
			gameOver = true;
			print ("GAME OVER!!!!");
		}
		if (collision.gameObject.tag != "Generating") {
			particleSys.Play ();
			audsource.PlayOneShot(BlackholeSuck);
			Destroy (collision.gameObject);
			print ("Destroyed object");
		}
				
	}
}
