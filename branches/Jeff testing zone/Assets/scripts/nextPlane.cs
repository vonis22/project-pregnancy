using UnityEngine;
using System.Collections;

public class nextPlane : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			ChangeToScene("MainMenu");
		}
	
	}
	public void ChangeToScene (string SceneToChangeTo)
	{
		Application.LoadLevel (SceneToChangeTo);
	}

}
