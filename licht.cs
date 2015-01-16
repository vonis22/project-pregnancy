using UnityEngine;
using System.Collections;

public class licht : MonoBehaviour {


	public float Kleur= 0.0f;

void Start()
{
	
}

void Update()
{
		if(Kleur==1.0f){

		renderer.material.color = new Color (30, 0, 0,0);
		}

	
}
}
