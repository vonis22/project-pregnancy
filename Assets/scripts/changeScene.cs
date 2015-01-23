using UnityEngine;
using System.Collections;

public class changeScene : MonoBehaviour {
	
	public void StartGame (string StartGame)
	{
		Application.LoadLevel (StartGame);
	}

	public void StartOptions (string Options)
	{
		Application.LoadLevel (Options);
	}

	public void StartInstructions (string Instructions)
	{
		Application.LoadLevel (Instructions);
	}

	/*public void SluitApp ()
	{
		Application.Quit();
	}*/
}