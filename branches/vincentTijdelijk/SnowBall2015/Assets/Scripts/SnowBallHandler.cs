using UnityEngine;
using System.Collections;

public class SnowBallHandler : MonoBehaviour {
	public GameObject snowball_prefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 if (Input.GetButtonDown("Fire1")){
			Instantiate(snowball_prefab, transform.position, transform.rotation);
	}
}
}