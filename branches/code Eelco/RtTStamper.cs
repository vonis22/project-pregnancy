using UnityEngine;
using System.Collections;

public class RtTStamper : MonoBehaviour 
{
	public Texture2D sourceTexture = null;

	Texture2D targetTexture = null;

	Texture2D originalTexture = null;

	void Start()
	{
		// Fetch the current texture
		targetTexture = (Texture2D)gameObject.GetComponent<Renderer>().material.mainTexture;
		
		// Make a backup of the original
		originalTexture = new Texture2D( targetTexture.width, targetTexture.height, targetTexture.format, false );
		originalTexture.SetPixels( 0, 0, originalTexture.width, originalTexture.height, 
		                          targetTexture.GetPixels( 0, 0, originalTexture.width, originalTexture.height ) );

		Camera c = Camera.Instantiate( Camera.main ) as Camera;
		//c.enabled = false;
		c.transform.position = new Vector3( -50, 0, -10 );
		c.transform.LookAt( new Vector3( -50, 0, 0 ) );
		c.rect = new Rect(0.0f,0,0.75f,1.0f);
		c.pixelRect = new Rect(12.5f,0,75.0f,64);
		Destroy( c.GetComponent<AudioListener>() );

		GameObject p = GameObject.CreatePrimitive(PrimitiveType.Plane);
		p.transform.position = new Vector3( -50, 0, 0 );
		p.transform.eulerAngles = new Vector3( 90, 180, 0 );

		Debug.Log( p.renderer.material );
		p.renderer.material.SetTexture( "_MainTex", sourceTexture );

		RenderTexture rt = new RenderTexture( 512, 512, 32, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear );
		c.targetTexture = rt;

		RenderTexture originalRenderTexture = RenderTexture.active;
		RenderTexture.active = rt;
		c.Render();

		Texture2D image = new Texture2D(512, 512);
		image.ReadPixels(new Rect(0, 0, 512, 512), 0, 0);
		image.Apply();
		RenderTexture.active = originalRenderTexture;

		renderer.material.SetTexture( "_MainTex", image );

	}

	void Update() 
	{
		// set up a camera





		//GameObject p = GameObject.CreatePrimitive(PrimitiveType.Plane);
		//p = Instantiate( p ) as GameObject;
		//p.transform.Rotate( new Vector3( 90, 180, 0 ) );

		//Debug.Log( p.renderer.material );

		//Destroy(p);


		// with a texture B in front of it

		// render it on texture A

		// put in A in this objects material as the one
	}
}
