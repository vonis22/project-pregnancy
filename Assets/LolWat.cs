using UnityEngine;
using System.Collections;

public class LolWat : MonoBehaviour {
//	Vector3 movement = new Vector3 ();
	//float speed = 5.0f;
	float timer = 1.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0 && timer >= -1) {

			transform.Translate (Vector3.up * Time.deltaTime);
				}

		if (timer <= -2) {
			transform.Translate (Vector3.down * Time.deltaTime);

				}
		if (timer <= -3) 
		{
			timer = 1.0f;
				}
		Debug.Log(timer);
	
	}
}
