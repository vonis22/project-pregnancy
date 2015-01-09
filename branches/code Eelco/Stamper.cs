using UnityEngine;
using System.Collections;

public class Stamper : MonoBehaviour 
{
	public Texture2D sourceTexture = null;

	Texture2D targetTexture = null;

	Texture2D originalTexture = null;

	public IntRect tr = new IntRect(0,0,64,64);
	public IntRect sr = new IntRect(0,0,64,64);

	void Start() 
	{
		// Fetch the current texture
		targetTexture = (Texture2D)gameObject.GetComponent<Renderer>().material.mainTexture;

		Texture2D copy = new Texture2D( sourceTexture.width, sourceTexture.height, sourceTexture.format, false );
		copy.SetPixels( sourceTexture.GetPixels() );
		sourceTexture = copy;

		// Make a backup of the original
		originalTexture = new Texture2D( targetTexture.width, targetTexture.height, targetTexture.format, targetTexture.mipmapCount > 0 );
		originalTexture.SetPixels( 0, 0, originalTexture.width, originalTexture.height, 
			targetTexture.GetPixels( 0, 0, originalTexture.width, originalTexture.height ) );

		Debug.Log( "source size = " + sourceTexture.width + ", " + sourceTexture.height );

		targetTexture.SetPixels( 0, 0, originalTexture.width, originalTexture.height, 
		                        originalTexture.GetPixels( 0, 0, originalTexture.width, originalTexture.height ) );
		
		tr.xMax = sr.xMax;
		tr.yMax = sr.yMax;
		
		//sourceTexture.Resize( targetTexture.width, targetTexture.height, sourceTexture.format, false );
		TextureScale.Bilinear( sourceTexture, tr.xMax-tr.x, tr.yMax-tr.y );
		sourceTexture.Apply();
		
		targetTexture.SetPixels( tr.x+50, tr.y, tr.xMax, tr.yMax, 
			sourceTexture.GetPixels( 0, 0, tr.xMax - tr.x, tr.yMax - tr.y) );
		
		targetTexture.Apply(false);


	}

	void Update()
	{

	}

	void OnDestroy()
	{
		// Restore the backup of the original
		targetTexture.SetPixels( 0, 0, originalTexture.width, originalTexture.height, 
		                        originalTexture.GetPixels( 0, 0, originalTexture.width, originalTexture.height ) );
		targetTexture.Apply();
	}
}

[System.Serializable]
public class IntRect
{
	public int x, y, xMax, yMax;

	public IntRect( int _x, int _y, int _xMax, int _yMax )
	{
		x = _x;
		y = _y;
		xMax = _xMax;
		yMax = _yMax;
	}
}