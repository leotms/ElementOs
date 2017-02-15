using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {

	public float OrbitDegress = 1f;
	private Vector3 defaultPosition = new Vector3(0.0f, 0.0f, -0.06f);
	private GameObject marcadorPadre;

	// Use this for initialization
	void Start () {
		marcadorPadre = this.transform.parent.GetChild(0).gameObject;
	}

	void Update() {
		marcadorPadre = this.transform.parent.GetChild(0).gameObject;
		transform.RotateAround (marcadorPadre.gameObject.transform.position, Vector3.forward, OrbitDegress);
	}

} 