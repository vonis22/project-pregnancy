using UnityEngine;
using System.Collections;

public class moveBlock : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//transform.rotation.y = Input.acceleration.y *10;
	}
	
	// Update is called once per frame
		void Update () 
	{
		Vector3 acceleration = new Vector3 (Input.acceleration.x, Input.acceleration.z, Input.acceleration.y);
		//float xAxis = Input.acceleration.x;
		//float zAxis = Input.acceleration.z;
		//float yAxis = Input.acceleration.y;
		//Vector3 rotate = transform.rotation;
		transform.rotation = Input.gyro.attitude;
		//rotate = Input.acceleration;

		//transform.Rotate(xAxis, yAxis, zAxis);
	
		Debug.Log (acceleration);

	}
}
