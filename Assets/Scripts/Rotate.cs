﻿using UnityEngine;

public class Rotate: MonoBehaviour 
{

	public float speed;

	void Update() 
	{
		// Rotate the object around its local X axis at 1 degree per second
		transform.Rotate(Vector3.up * speed);
	}
}