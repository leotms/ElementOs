using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SceneController : MonoBehaviour {

	private Vector3 defaultPosition = new Vector3(0.0f, 0.0f, -0.06f);
	private Vector3 defaultScale    = new Vector3(0.1f, 0.1f, 0.1f);
	private Vector3 defaultTextPos  = new Vector3(0.0f, -0.05f, -0.066f);

	public  GameObject MarkerUnion;
	public  GameObject MarkerUnion2;

	public  GameObject Union;
	public  GameObject Agua;
	public  GameObject Tierra;
	public  GameObject Fuego;
	public  GameObject Aire;
	public  GameObject Text;

	public GameObject MarkerAgua;
	public GameObject MarkerTierra;
	public GameObject MarkerFuego;
	public GameObject MarkerAire;

	public GameObject Title;
	public GameObject UnionTitle;

	private bool flag = true;

	void resetElementByName(string Name) {
		print ("RESETEANDO ELEMENTO");
		print(Name);
		
		if (Name == "Fuego") {
			resetElement (Fuego, MarkerFuego, "Fuego");
		}
		if (Name == "Agua") {
			resetElement (Agua, MarkerAgua, "Agua");
		}
		if (Name == "Tierra") {
			resetElement (Tierra, MarkerTierra, "Tierra");
		}
		if (Name == "Aire") {
			resetElement (Aire, MarkerAire, "Aire");
		}

	}

	void resetElement(GameObject Element, GameObject Marker, string Nombre) {
		
		GameObject newElement;
		GameObject newText;

		if (Marker.transform.childCount > 0) {
			Destroy(Marker.transform.GetChild (0).gameObject);
			Destroy(Marker.transform.GetChild (1).gameObject);
		}

		newElement = (GameObject)PrefabUtility.InstantiatePrefab (Element);
		newElement.SetActive (false);
		newElement.transform.SetParent (Marker.transform);
		newElement.transform.localPosition = defaultPosition;
		newElement.transform.localScale = defaultScale;
		newElement.transform.gameObject.layer = Marker.transform.gameObject.layer;
		newElement.transform.gameObject.tag = Nombre;

		newText = (GameObject)PrefabUtility.InstantiatePrefab (Text);
		newText.SetActive(false);
		newText.transform.SetParent (Marker.transform);
		newText.transform.localPosition = defaultTextPos;
		newText.transform.GetComponent<TextMesh> ().text = Nombre;
	
			
	}


	void activate (string Union){
		if (Union == "1" && MarkerUnion.activeSelf) {
			resetUnion ();
			print ("RESET 1");
		}

		if (Union == "2" && !flag) {
			resetUnionAux ();
			print ("RESET 2");
		} 

		if (Union == "2" && flag) {
			MarkerUnion2.SetActive (true);
			flag = false;
		}
	}


	void startGame(){
		MarkerUnion.SetActive (true);
		MarkerAgua.SetActive (true);
		MarkerTierra.SetActive (true);
		MarkerFuego.SetActive (true);
		MarkerAire.SetActive (true);

		this.GetComponent<AudioSource>().Play ();

		Destroy (Title);
		Destroy (UnionTitle);
	}

	void resetUnion() {

		print ("ENTRE1");
		//yield return new WaitForSeconds (3);

		GameObject newElement;
		GameObject newText;

		newElement = (GameObject)PrefabUtility.InstantiatePrefab (Union);
		newElement.SetActive (false);
		newElement.transform.SetParent (MarkerUnion.transform);
		newElement.transform.localPosition    = new Vector3(0.0f, 0.0f, -0.06f);
		newElement.transform.localScale       = defaultScale;
		newElement.transform.gameObject.layer = MarkerUnion.transform.gameObject.layer;
		newElement.transform.gameObject.tag   = MarkerUnion.transform.gameObject.tag;
		print ("Aqui");
		print (newElement.transform.parent.gameObject.name);

		newText = (GameObject)PrefabUtility.InstantiatePrefab (Text);
		newText.SetActive(false);
		newText.transform.SetParent (MarkerUnion.transform);
		newText.transform.localPosition = defaultTextPos;
		newText.transform.GetComponent<TextMesh> ().text = "Union";

	} 

	void resetUnionAux() {

		print ("ENTRE2");
		//yield return new WaitForSeconds (3);

		GameObject newElement;
		GameObject newText;

		newElement = (GameObject)PrefabUtility.InstantiatePrefab (Union);
		newElement.SetActive (false);
		newElement.transform.SetParent (MarkerUnion2.transform);
		newElement.transform.localPosition    = new Vector3(0.0f, 0.0f, -0.06f);
		newElement.transform.localScale       = defaultScale;
		newElement.transform.gameObject.layer = MarkerUnion2.transform.gameObject.layer;
		newElement.transform.gameObject.tag   = MarkerUnion2.transform.gameObject.tag;

		newText = (GameObject)PrefabUtility.InstantiatePrefab (Text);
		newText.SetActive(false);
		newText.transform.SetParent (MarkerUnion2.transform);
		newText.transform.localPosition = defaultTextPos;
		newText.transform.GetComponent<TextMesh> ().text = "Union";

	} 
}
