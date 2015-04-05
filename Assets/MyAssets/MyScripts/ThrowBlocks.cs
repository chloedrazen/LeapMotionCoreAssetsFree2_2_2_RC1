using UnityEngine;
using System.Collections;

public class ThrowBlocks : MonoBehaviour {

	//public Rigidbody cube;
	public int enumm = 0;
	public Rigidbody cube;
	public int frequency = 20;
	public float count = 0;
	bool play = false; 
	//public static Object Instantiate(Object cube);

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		count += Time.deltaTime;
//		print (count);
		if (count > 3.0f) {
			play = true;
		}
		if (play) {
			print (Time.deltaTime);
			//enumm += Time.deltaTime;
			enumm ++;
		

			if (enumm % frequency == 0)
				makeCubes ();
		}


	}
	void makeCubes(){

		Rigidbody cubeClone;
		Vector3 startPos = new Vector3 (cube.transform.position.x, 5.39f, cube.transform.position.z);
		cubeClone = Instantiate (cube.GetComponent<Rigidbody>(), startPos ,cube.transform.rotation) as Rigidbody;

		cubeClone.useGravity = false;
	
		cubeClone.velocity = cube.transform.TransformDirection (Vector3.forward * 1);
	}
//	void CreateNewTarPoint()
//	{
//		tarX = Random.Range (xMin, xMax);
//		tarY = Random.Range (yMin, yMax);
//		tarZ = Random.Range (zMin, zMax);
//		target = new Vector3 (tarX, tarY, tarZ);
//	}

}
