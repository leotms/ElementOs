using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class StartGame : MonoBehaviour {
	// Update is called once per frame

	static AudioSource Audio;

	void Start(){
		Audio = this.transform.GetComponent<AudioSource>();
	}
	void Update () {
		if (this.gameObject.activeSelf) {
			Audio.Play ();
			this.transform.parent.SendMessage ("startGame");
		}
	}
}