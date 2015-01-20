using UnityEngine;
using System.Collections;

public class licht : MonoBehaviour
{
	// Alpha kanaal van de kleur moet gestart worden op het moment dat 1 van de timers (BreathOut)s 0 wordt,
	// Hierna moet hij hervat worden als de andere (BreathIn) time 0 is.
	public float kleur =0.0f;
	public float colourTimer = 0.0f;
	public float roundedColourTimer;
	public float r = 0.0f;
	public float g = 0.0f;
	public float b = 0.0f;
	public float a = 0.0f;
	//6 t/m 11 kunnen weg gehaald worden. zijn geen mooie roundedColourTimeren


	void Start()
	{

	}


	void Update()
	{

		//Niels deze 2 regels zijn de timer, exclusief de debug.log
		kleur += Time.deltaTime;
		roundedColourTimer = Mathf.Floor (kleur);
		//Debug.Log (roundedColourTimer);

		InvokeRepeating("optellen", 1.0f, 20.0f);
		renderer.material.color = new Color (r/255, g/255, b/255, 1);
		//Kleur verandering
		if( roundedColourTimer >= 2 && roundedColourTimer < 7)
		{
			if (r < 220) 
			{
				r++;
			}
			else
			{
				r--;
			}
			if (g < 0) 
			{
				g++;
			}
			else {
				g--;
			}
			if (b < 0) 
			{
				b++;
			}
			else {
				b--;
			}

		} 
		if( roundedColourTimer >= 7 && roundedColourTimer  < 11)
		{
			if (r < 255) 
			{
				r++;
			}
			else
			{
				r--;
			}
			if (g < 69) 
			{
				g++;
			}
			else {
				g--;
			}
			if (b < 0) 
			{
				b++;
			}
			else {
				b--;
			}
			
		} 

		if( roundedColourTimer >= 11)
		{
			if (r < 0) 
			{
				r++;
			}
			else
			{
				r--;
			}
			if (g < 255) 
			{
				g++;
			}
			else {
				g--;
			}
			if (b < 0) 
			{
				b++;
			}
			else {
				b--;
			}
			
		}


	}
}