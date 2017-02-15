using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class UnionMarker2 : MonoBehaviour {

	private Vector3 defaultPosition = new Vector3(0.0f, 0.0f, -0.06f);
	private Vector3 defaultScale    = new Vector3(0.1f, 0.1f, 0.1f);
	private Vector3 defaultTextPos  = new Vector3(0.0f, -0.05f, -0.066f);

	private GameObject child;
	private GameObject child2;

	// import prefabs
	public  GameObject Union;
	public  GameObject Lava;
	public  GameObject Vapor;
	public  GameObject Humo;
	public  GameObject Hielo;
	public  GameObject Polvo;
	public  GameObject Lodo;
	public  GameObject Piedra;
	public  GameObject Arcilla;
	public  GameObject Nubes;
	public  GameObject Arena;
	public  GameObject Ceniza;
	public  GameObject Vidrio;
	public  GameObject Lluvia;
	public  GameObject Nieve;
	public  GameObject Ceramica;
	public  GameObject Agua;
	//

	public  GameObject Text;
	private GameObject marcadorPadre;

	// Use this for initialization
	void Start () {
		
		marcadorPadre = this.transform.parent.gameObject;

	}

	// Update is called once per frame
	void Update () {

	}

	void imprimir(string Mensaje){
		print (Mensaje);
	}

	void changeElement(string Element){

		GameObject newElement;
		GameObject newText;

		if (Element == "Lava") {
			createElement (Element, Lava);
			marcadorPadre.SendMessage ("resetElementByName", "Agua");
		}
		if (Element == "Vapor") {
			createElement (Element, Vapor);
		}
		if (Element == "Humo") {
			createElement (Element, Humo);
		}
		if (Element == "Hielo") {
			createElement (Element, Hielo);
			marcadorPadre.SendMessage ("resetElementByName", "Aire");
		}
		if (Element == "Lodo") {
			createElement (Element, Lodo);
			marcadorPadre.SendMessage ("resetElementByName", "Fuego");
		}
		if (Element == "Polvo") {
			createElement (Element, Polvo);
			marcadorPadre.SendMessage ("resetElementByName", "Fuego");
		}
		if (Element == "Piedra") {
			createElement (Element, Piedra);
			marcadorPadre.SendMessage ("resetElementByName", "Aire");
		}
		if (Element == "Arcilla") {
			createElement (Element, Arcilla);
			marcadorPadre.SendMessage ("resetElementByName", "Fuego");
		}
		if (Element == "Nubes") {
			createElement (Element, Nubes);
			marcadorPadre.SendMessage ("resetElementByName", "Agua");
		}
		if (Element == "Arena") {
			createElement (Element, Arena);
			marcadorPadre.SendMessage ("resetElementByName", "Fuego");
		}
		if (Element == "Ceniza") {
			createElement (Element, Ceniza);
		}
		if (Element == "Vidrio") {
			createElement (Element, Vidrio);
		}
		if (Element == "Lluvia") {
			createElement (Element, Lluvia);
			marcadorPadre.SendMessage ("resetElementByName", "Fuego");
		}
		if (Element == "Nieve") {
			createElement (Element, Nieve);
			marcadorPadre.SendMessage ("resetElementByName", "Fuego");
		}
		if (Element == "Ceramica") {
			createElement (Element, Ceramica);
		}
		if (Element == "Agua") {
			createElement (Element, Agua);
			marcadorPadre.SendMessage ("resetElementByName", "Fuego");
			marcadorPadre.SendMessage ("resetElementByName", "Aire");
			marcadorPadre.SendMessage ("resetElementByName", "Tierra");
		}
	}

	void changeText(string Text) {
		this.transform.GetChild (1).gameObject.transform.GetComponent<TextMesh>().text = Text + " + ?";
	}

	void createElement(string Element, GameObject ElementGO) {

		child  = this.transform.GetChild (0).gameObject;
		child2 = this.transform.GetChild (1).gameObject;

		GameObject newElement;
		GameObject newText;

		newElement = (GameObject)PrefabUtility.InstantiatePrefab (ElementGO);
		newElement.transform.SetParent (this.transform);
		newElement.transform.localPosition = defaultPosition;
		newElement.transform.localScale    = defaultScale;
		newElement.transform.gameObject.layer = this.transform.gameObject.layer;
		newElement.transform.gameObject.tag   = Element;


		newText = (GameObject)PrefabUtility.InstantiatePrefab (Text);
		newText.transform.SetParent (this.transform);
		newText.transform.localPosition = defaultTextPos;
		newText.transform.GetComponent<TextMesh> ().text = Element;

		Destroy (child);
		Destroy (child2);

		this.GetComponent<AudioSource>().Play ();

		//we activate the other mark
		marcadorPadre.SendMessage ("activate", "1");
	}

}
