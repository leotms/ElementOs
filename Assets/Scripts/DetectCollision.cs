using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour {

	private string first_element  = "";
	private string second_element = "";

	private GameObject marcadorPadre;
	public  AudioSource Error;
	public  AudioSource Absorbe;

	// Use this for initialization
	void Start () {
		marcadorPadre = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col) {
		if (first_element == "") {
			first_element = col.gameObject.tag;
			print (col.gameObject.tag);
			print (col.gameObject.name);
			Destroy (col.gameObject.transform.parent.GetChild (1).gameObject);
			Destroy(col.gameObject);
			Absorbe.Play ();
			marcadorPadre.SendMessage ("changeText", first_element);
			print ("FIRST ELEMENT");
		
		} else {
			print ("ENTRO");
			second_element = col.gameObject.tag;
			Destroy (col.gameObject.transform.parent.GetChild (1).gameObject);
			Destroy(col.gameObject);
			print ("SECOND ELEMENT");
			checkCombine ();
		}
	}

	void checkCombine() {
		if (first_element == "Fuego" && second_element == "Tierra"
		    || first_element == "Tierra" && second_element == "Fuego") {
			marcadorPadre.SendMessage ("changeElement", "Lava");
		} else if (first_element == "Fuego" && second_element == "Aire"
		         || first_element == "Aire" && second_element == "Fuego") {
			marcadorPadre.SendMessage ("changeElement", "Humo");
		} else if (first_element == "Fuego" && second_element == "Agua"
		         || first_element == "Agua" && second_element == "Fuego") {
			marcadorPadre.SendMessage ("changeElement", "Vapor");
		} else if (first_element == "Aire" && second_element == "Agua"
		         || first_element == "Agua" && second_element == "Aire") {
			marcadorPadre.SendMessage ("changeElement", "Hielo");
		} else if (first_element == "Aire" && second_element == "Tierra"
		         || first_element == "Tierra" && second_element == "Aire") {
			marcadorPadre.SendMessage ("changeElement", "Polvo");
		} else if (first_element == "Agua" && second_element == "Tierra"
		         || first_element == "Tierra" && second_element == "Agua") {
			marcadorPadre.SendMessage ("changeElement", "Lodo");
		} else if (first_element == "Lava" && second_element == "Agua"
		         || first_element == "Agua" && second_element == "Lava") {
			marcadorPadre.SendMessage ("changeElement", "Piedra");
		} else if (first_element == "Lodo" && second_element == "Fuego"
		         || first_element == "Fuego" && second_element == "Lodo") {
			marcadorPadre.SendMessage ("changeElement", "Arcilla");
		} else if (first_element == "Aire" && second_element == "Vapor"
		         || first_element == "Vapor" && second_element == "Aire") {
			marcadorPadre.SendMessage ("changeElement", "Nubes");
		} else if (first_element == "Aire" && second_element == "Piedra"
		         || first_element == "Piedra" && second_element == "Aire") {
			marcadorPadre.SendMessage ("changeElement", "Arena");
		} else if (first_element == "Polvo" && second_element == "Fuego"
		         || first_element == "Fuego" && second_element == "Polvo") {
			marcadorPadre.SendMessage ("changeElement", "Ceniza");
		} else if (first_element == "Arena" && second_element == "Fuego"
		         || first_element == "Fuego" && second_element == "Vidrio") {
			marcadorPadre.SendMessage ("changeElement", "Vidrio");
		} else if (first_element == "Nubes" && second_element == "Agua"
		         || first_element == "Agua" && second_element == "Nubes") {
			marcadorPadre.SendMessage ("changeElement", "Lluvia");
		} else if (first_element == "Hielo" && second_element == "Aire"
		         || first_element == "Aire" && second_element == "Hielo") {
			marcadorPadre.SendMessage ("changeElement", "Nieve");
		} else if (first_element == "Arcilla" && second_element == "Fuego"
		         || first_element == "Fuego" && second_element == "Arcilla") {
			marcadorPadre.SendMessage ("changeElement", "Ceramica");
		} else if (first_element == "Hielo" && second_element == "Fuego"
		         || first_element == "Fuego" && second_element == "Hielo") {
			marcadorPadre.SendMessage ("changeElement", "Agua");
		} else if (first_element == "Nieve" && second_element == "Fuego"
		         || first_element == "Fuego" && second_element == "Nieve") {
			marcadorPadre.SendMessage ("changeElement", "Agua");
		} else if (first_element == "Arcilla" && second_element == "Lluvia"
		         || first_element == "Lluvia" && second_element == "Arcilla") {
			marcadorPadre.SendMessage ("changeElement", "Lodo");
		} else if (first_element == "Arcilla" && second_element == "Agua"
		         || first_element == "Agua" && second_element == "Arcilla") {
			marcadorPadre.SendMessage ("changeElement", "Lodo");
		} else {
			this.transform.parent.transform.parent.transform.SendMessage ("resetElementByName", "Fuego");
			this.transform.parent.transform.parent.transform.SendMessage ("resetElementByName", "Agua");
			this.transform.parent.transform.parent.transform.SendMessage ("resetElementByName", "Tierra");
			this.transform.parent.transform.parent.transform.SendMessage ("resetElementByName", "Aire");
			first_element  = "";
			second_element = "";
			Error.Play ();
		}
	}


}
