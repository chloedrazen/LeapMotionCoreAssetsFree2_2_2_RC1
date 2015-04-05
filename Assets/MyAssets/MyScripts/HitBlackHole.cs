using UnityEngine;
using System.Collections;

public class HitBlackHole : MonoBehaviour {
		//public int score = 0;
		// Use this for initialization
	void Start () {
	}
		
		//Update is called once per frame
		void Update () {
						
		}
		void OnTriggerEnter(Collider other)
			{
				Rigidbody rb = other.attachedRigidbody;
				Vector3 force = new Vector3 (0,-3000,0);
				rb.AddForce ( force );
				print ("hit BLACK HOLE");
			}

	}
