using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour {
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown(0))
		{			
			transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
			Debug.LogFormat("Flip. New scale: {0}", transform.localScale);
		}
	}
}
