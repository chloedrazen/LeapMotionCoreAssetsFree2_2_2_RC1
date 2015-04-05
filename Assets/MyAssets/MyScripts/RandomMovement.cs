using UnityEngine;
using System.Collections;

public class RandomMovement : MonoBehaviour {

	//public Vector3 aPosition = new Vector3(1, 1, 1);
	private float xMin =  -3.6f;
	private float xMax = 4.1f;
	private float yMin = -.86f;
	public float yMax = 3.39f;
	private float zMin = -5.94f;
	private float zMax = -0.23f;
	private float tarX;
	private float tarY;
	private float tarZ;
	public Vector3 target;
	public float speed = 0.3f;

	// Use this for initialization
	void Start () {
		CreateNewTarPoint ();
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp (transform.position, target , speed * Time.deltaTime);
		isWithinRange ();
		//print (target);
	}

	void CreateNewTarPoint()
	{
		tarX = Random.Range (xMin, xMax);
		tarY = Random.Range (yMin, yMax);
		tarZ = Random.Range (zMin, zMax);
		target = new Vector3 (tarX, tarY, tarZ);
	}
	
	void isWithinRange()
	{
		Vector3 targetPoint = new Vector3 (tarX, tarY, tarZ);
		Vector3 dir = targetPoint - transform.position;
		if (Vector3.Distance (targetPoint, transform.position) < 0.1f) 
		{
			CreateNewTarPoint();
		}
	}
	void OnCollisionEnter(Collision collision) {
		if (collision.transform.tag == "Wall") {
			print ("hit wall");
			CreateNewTarPoint ();
		}
		
	}
}
