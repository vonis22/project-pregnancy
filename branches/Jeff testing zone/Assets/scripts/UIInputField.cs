using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIInputField : MonoBehaviour {
	public Text InputText;
	// Use this for initialization
	void Start () {
		InputText = GameObject.Find ("InputText").GetComponent<Text>();
	}
	public void CharacterField(string inputFieldString)
	{
		InputText.text = inputFieldString;
	}
}
