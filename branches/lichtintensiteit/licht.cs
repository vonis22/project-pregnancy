using UnityEngine;
using System.Collections;

public class licht : MonoBehaviour
{
	public float Kleur = 0;

	void Start()
	{
		
	}

	void Update()
	{
		if (Kleur == 1)
		{
			renderer.material.color = new Color (30, 0, 0,0);
		}

		if (Kleur == 2)
		{
			renderer.material.color = new Color (0, 30, 0,0)
		}

		if (Kleur == 3)
		{
			renderer.material.color = new Color (0, 0, 30,0)
		}
	}
}
