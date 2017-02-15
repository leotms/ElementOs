using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MakerStart : MonoBehaviour {

	void startGame(){
		this.transform.parent.SendMessage ("startGame");
		Destroy (this.gameObject);
	}

}
