using UnityEngine;
using System.Collections;


public class cubesDraaien : MonoBehaviour {
	public float yWaarde;
	public float xWaarde;
		public float speed = 10.0F;
		
		void Update() 
	{
		transform.rotation = Input.gyro.attitude;



		//gemiddelde berekenen van 10 waardes, uitgaande van het feit dat de telefoon landscape op de buik ligt
		
		//Uitademen, laagste waarden
		
		//Inademen, hoogste waarden

				Vector3 dir = Vector3.zero;
				yWaarde = -Input.acceleration.y;
				xWaarde = Input.acceleration.x;
		
				dir.x = yWaarde*360.0f;
				dir.z = xWaarde*360.0f;
				dir *= Time.deltaTime;
					transform.Rotate(dir * speed);

				Debug.Log ("x"+Input.acceleration.y);
				Debug.Log ("z"+Input.acceleration.x);
		}
}