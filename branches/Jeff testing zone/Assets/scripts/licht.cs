using UnityEngine;
using System.Collections.Generic;
using System;
using System.Linq;

public class licht : MonoBehaviour
{
	// Alpha kanaal van de kleur moet gestart worden op het moment dat 1 van de timers (BreathOut)s 0 wordt,
	// Hierna moet hij hervat worden als de andere (BreathIn) time 0 is.
	public float kleur =0.0f;
	public float colourTimer = 0.0f;
	public float r = 0.0f;
	public float g = 0.0f;
	public float b = 0.0f;
	public float a = 0.0f;

	public playPhase method;
	public float lightIntensity = 50.0f;

	public float breathInTimer = 0.0f;
	public float breathOutTimer = 0.0f;
	public float fullBreath;

	public AudioClip langzamer;
	public AudioClip sneller;
	public AudioClip ademIn;
	public AudioClip ademUit;

	public bool canPlaySound = true;
	public float canPlaySoundTimer = 0.0f;


	void Start()
	{
		//GameObject script1 = this.GetComponent<playPhase> ();
		method = this.GetComponent<playPhase> ();
		breathInTimer = method.breathInTimer;
		breathOutTimer = method.breathOutTimer;
		fullBreath = method.fullBreathList.Last();
	}


	void Update()
	{
		renderer.material.color = new Color (r/255, g/255, b/255, lightIntensity/100);

		//Debug.Log (method.fullBreathList.Last ());
		//Kleur verandering
		if(method.fullBreathList.Last () <= 2 || method.fullBreathList.Last () >= 6)
		{
			audio.Stop();
			audio.clip = langzamer;
			audio.Play ();
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

		if(method.fullBreathList.Last () <= 3 && method.fullBreathList.Last () > 2 || method.fullBreathList.Last () >= 5 && method.fullBreathList.Last () < 6)
		{
			Debug.Log (canPlaySound);

			if (canPlaySound)
			{
			audio.clip = sneller;
			audio.Play ();
			canPlaySound = false;
			}

			if (canPlaySoundTimer <= 4.0f && canPlaySound == false) 
			{
				canPlaySoundTimer += 1.0f * Time.deltaTime;
			}
			else
			{
				canPlaySoundTimer = 0.0f;
				canPlaySound = true;
			}

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

		if(method.fullBreathList.Last () >= 3 && method.fullBreathList.Last () < 5)
		{
			audio.Stop();
			audio.clip = ademIn;
			audio.Play ();
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

		//De lichtintensiteit
		if (lightIntensity <= 100)
		{
			lightIntensity += method.breathInTimer *10 * Time.deltaTime; 
		}
		
		if (lightIntensity >= 0)
		{
			lightIntensity -= method.breathOutTimer *10 * Time.deltaTime;
		}
	}
}