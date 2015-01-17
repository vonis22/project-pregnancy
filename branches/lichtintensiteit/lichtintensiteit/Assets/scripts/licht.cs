using UnityEngine;
using System.Collections;

public class licht : MonoBehaviour
{

	public float Kleur =0.0f;
	public float colourTimer = 0.0f;
	public float roundedColourTimer;
	//6 t/m 11 kunnen weg gehaald worden. zijn geen mooie kleuren


	void Start()
	{

	}


	void Update()
	{
		//Niels deze 2 regels zijn de timer, exclusief de debug.log
		colourTimer += Time.deltaTime;
		roundedColourTimer = Mathf.Floor (colourTimer);
		Debug.Log (roundedColourTimer);

		InvokeRepeating("optellen", 1.0f, 20.0f);

		//Rood
		if(Kleur == 1)
		{
			renderer.material.color = new Color (255.0f/255, 0.0f/255, 0.0f/255, 1);
		}

		if(Kleur == 2)
		{
			renderer.material.color = new Color (255.0f/255, 0.0f/255, 0.0f/255, 0.9f);
		}

		if(Kleur == 3)
		{
			renderer.material.color = new Color (255.0f/255, 0.0f/255, 0.0f/255, 0.8f);
		}

		if(Kleur == 4)
		{
			renderer.material.color = new Color (255.0f/255, 0.0f/255, 0.0f/255, 0.7f);
		}

		if(Kleur == 5)
		{
			renderer.material.color = new Color (255.0f/255, 0.0f/255, 0.0f/255, 0.6f);
		}

		//		if(Kleur == 15)
		//		{
		//			renderer.material.color = new Color (255.0f/255, 0.0f/255, 0.0f/255, 0.5f);
		//		}
		//
		//		if(Kleur == 16)
		//		{
		//			renderer.material.color = new Color (255.0f/255, 0.0f/255, 0.0f/255, 0.4f);
		//		}
		//
		//		if(Kleur == 17)
		//		{
		//			renderer.material.color = new Color (255.0f/255, 0.0f/255, 0.0f/255, 0.3f);
		//		}
		//
		//		if(Kleur == 18)
		//		{
		//			renderer.material.color = new Color (255.0f/255, 0.0f/255, 0.0f/255, 0.2f);
		//		}
		//
		//		if(Kleur == 19)
		//		{
		//			renderer.material.color = new Color (255.0f/255, 0.0f/255, 0.0f/255, 0.1f);
		//		}

		//Oranje
		if(Kleur == 6)
		{
			renderer.material.color = new Color (255.0f/255, 127.0f/255, 36.0f/255, 0.1f);
		}

		if(Kleur == 7)
		{
			renderer.material.color = new Color (255.0f/255, 127.0f/255, 36.0f/255, 0.2f);
		}

		if(Kleur == 8)
		{
			renderer.material.color = new Color (255.0f/255, 127.0f/255, 36.0f/255, 0.3f);
		}

		if(Kleur == 9)
		{
			renderer.material.color = new Color (255.0f/255, 127.0f/255, 36.0f/255, 0.4f);
		}

		if(Kleur == 10)
		{
			renderer.material.color = new Color (255.0f/255, 127.0f/255, 36.0f/255, 0.5f);
		}

		if(Kleur == 11)
		{
			renderer.material.color = new Color (255.0f/255, 127.0f/255, 36.0f/255, 0.6f);
		}

		if(Kleur == 12)
		{
			renderer.material.color = new Color (255.0f/255, 127.0f/255, 36.0f/255, 0.7f);
		}

		if(Kleur == 13)
		{
			renderer.material.color = new Color (255.0f/255, 127.0f/255, 36.0f/255, 0.8f);
		}

		if(Kleur == 14)
		{
			renderer.material.color = new Color (255.0f/255, 127.0f/255, 36.0f/255, 0.9f);
		}

		if(Kleur == 15)
		{
			renderer.material.color = new Color (255.0f/255, 127.0f/255, 36.0f/255, 1);
		}

		//Groen
		//		if(Kleur == 3)
		//		{
		//			renderer.material.color = new Color (0.0f/255, 255.0f/255, 0.0f/255, 0.1f);
		//		}
		//
		//		if(Kleur == 31)
		//		{
		//			renderer.material.color = new Color (0.0f/255, 255.0f/255, 0.0f/255, 0.2f);
		//		}
		//
		//		if(Kleur == 32)
		//		{
		//			renderer.material.color = new Color (0.0f/255, 255.0f/255, 0.0f/255, 0.3f);
		//		}
		//
		//		if(Kleur == 33)
		//		{
		//			renderer.material.color = new Color (0.0f/255, 255.0f/255, 0.0f/255, 0.4f);
		//		}
		//
		//		if(Kleur == 34)
		//		{
		//			renderer.material.color = new Color (0.0f/255, 255.0f/255, 0.0f/255, 0.5f);
		//		}

		if(Kleur == 16)
		{
			renderer.material.color = new Color (0.0f/255, 255.0f/255, 0.0f/255, 0.6f);
		}

		if(Kleur == 17)
		{
			renderer.material.color = new Color (0.0f/255, 255.0f/255, 0.0f/255, 0.7f);
		}

		if(Kleur == 18)
		{
			renderer.material.color = new Color (0.0f/255, 255.0f/255, 0.0f/255, 0.8f);
		}

		if(Kleur == 19)
		{
			renderer.material.color = new Color (0.0f/255, 255.0f/255, 0.0f/255, 0.9f);
		}

		if(Kleur == 20)
		{
			renderer.material.color = new Color (0.0f/255, 255.0f/255, 0.0f/255, 1);
		}
	}
}