using UnityEngine;
using System.Collections.Generic;


public class cubesDraaien : MonoBehaviour {

	//tappen op telefoon voor starten

	public float yWaarde;
	public float xWaarde;
	public float speed = 10.0f;

	public float calTimer = 30.0f;
	public bool gameRunning = false;
	public float calibrating = 0.0f;
	public bool starting = false;

	//public List<float> maxX = new List<float>(); 
	public List<float> maxY = new List<float>();
	//public List<float> minX = new List<float>();
	public List<float> minY = new List<float>();

	//float currentX;
	float currentY;
	//float avgX;
	float avgY;	

		
		void Start()
		{
			starting = true;
			repeating ();
		}

		void Update() 
		{
			transform.rotation = Input.gyro.attitude;
			gameRunning = true;
			

		//gemiddelde berekenen van 10 waardes, uitgaande van het feit dat de telefoon landscape op de buik ligt
		//Uitademen, laagste waarden
		//Inademen, hoogste waarden

			Vector3 dir = Vector3.zero;
			yWaarde = Input.acceleration.y;
			//xWaarde = Input.acceleration.x;
	
			//dir.x = yWaarde*360.0f;
			dir.z = xWaarde*360.0f;
			dir *= Time.deltaTime;
			transform.Rotate(dir * speed);

			if (gameRunning)
			{
				calTimer -= Time.deltaTime;
				
				if(starting == false)
				{
					starting = false;
				}
			}

			if (calTimer <= 0)
			{
				CancelInvoke();
				calTimer = 0;
			}
				//currentX = Input.acceleration.x;
				currentY = Input.acceleration.y;

				//Debug.Log (maxX);
				//Debug.Log (maxY);
				//print(maxX);
				
				//Debug.Log (calTimer);
				//Debug.Log (calibrating);
				//Debug.Log ("x"+Input.acceleration.y *100);
				//Debug.Log ("z"+Input.acceleration.x *100);
				//RenderSettings.ambientLight
		}
		
		//1x aangeroepen in 4 sec
		void calibration()
		{
			//float tmpX = currentX;
			float tmpY = currentY;

			
			

			
			

			if (currentY < 0.0f)
			{
				minY.Add(tmpY);
			}
			else
			{
				maxY.Add(tmpY);
			}

//			if (currentX < 0.0f)
//			{
//				minX.Add (tmpX);
//			}
//			else
//			{
//				maxX.Add(tmpX);
//			}

			

			

		}

		void repeating()
		{
			if (starting)
			{
			InvokeRepeating("calibration", 4.0f, 4.0f);
			starting = false;
			}
		}






}