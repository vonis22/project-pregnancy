﻿using UnityEngine;
using System.Collections;

public class cubesDraaien : MonoBehaviour {

	// Use this for initialization
	//void Start () {
	//Input.gyro.enabled= true; 
	//}
	
	// Update is called once per frame
	/*void Update () {
		//Input.gyro.enabled= true; 
		//float Xaxis = Input.gyro.userAcceleration * 0.1f;
		//float Zaxis = Input.acceleration.z * 0.1f;
		//Vector3 gyroscoop = new Vector3 ();
		//gyroscoop = (Input.gyro.userAcceleration);
		transform.Rotate(Input.gyro.attitude.x,0,Input.gyro.attitude.z);
		Debug.Log (Input.gyro.rotationRate);
		//transform.rotation = ConvertRotation(Input.gyro.attitude);
		}
	}*/


// Move object using accelerometer

		public float speed = 10.0F;
		void Update() {
			Vector3 dir = Vector3.zero;
		float xWaarde = -Input.acceleration.y;
		float zWaarde = Input.acceleration.x;


//		transform.rotation.x += dir.x;
//		transform.rotation.z += dir.z;
			//dir.y = Input.acceleration.y * 50.0f;
			//if (dir.sqrMagnitude > 1)
			//	dir.Normalize();
		if ((xWaarde <= 0.1f)  && (xWaarde >= -0.1f)) {
						xWaarde = 0.0f;
				}
		if ((zWaarde <= 0.01f) && (zWaarde >= -0.01f)) {
						zWaarde = 0.0f;
				}

		dir.x = xWaarde*50.0f;//-Input.acceleration.y*100.0f;
		dir.z = zWaarde*50.0f;//Input.acceleration.x*100.0f;
		dir *= Time.deltaTime;
			transform.Rotate(dir * speed);
		Debug.Log ("x"+Input.acceleration.y);
		Debug.Log ("z"+Input.acceleration.x);


		}
}



	
	

