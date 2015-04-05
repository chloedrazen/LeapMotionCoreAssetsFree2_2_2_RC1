using UnityEngine;
using System.Collections;

public class HitTarget : MonoBehaviour {

	public int score = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	//Update is called once per frame
	void Update () {
//		Vector3 target = targetPoint.position;
//		Vector3 distance = target - transform.position;
//		if (Vector3.Distance (target, transform.position) < 0.2f){
//			score++;
//			print ("Score: ", score);

	}
	void OnTriggerEnter(Collider other) {
		if (other.tag == "SpecialCube") {
			score ++;
			Destroy (other.gameObject);
			print ("score!trigger");
		}
	}
	void OnCollisionEnter(Collision collision) {
		
		if (collision.gameObject.tag == "SpecialCube") {
			score ++;
			Destroy (collision.gameObject);
			print ("score!colllision");
		}
		
	}
}
