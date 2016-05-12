using UnityEngine;
using System.Collections;

public class Timer_Schalter : MonoBehaviour {

	public GameObject Tuer;
	public float zeit = 5f;
	public bool Schalter = false;
	public bool imTrigger = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (imTrigger == true) {
			if (Input.GetKeyDown (KeyCode.E)) {
				Schalter = true;
			}
		}
		
			if (Schalter == true) {
				if (zeit > 0) {
					zeit = zeit - Time.deltaTime;
					Tuer.GetComponent <Door_Open> ().Open = true;
				} else {
					Tuer.GetComponent <Door_Open> ().Open = false;
					Schalter = false;
					zeit = 5f;
				
				}
			}
		
	}
	void OnTriggerEnter (Collider other ){
		if (other.tag == "Player") {
			imTrigger = true;
		}
	}
	void OnTriggerExit (Collider other){
		if (other.tag == "Player") {
			imTrigger = false;
		}
	}
	void OnMouseDown(){
		if (imTrigger == true) {
			Schalter = true;
		}
	}
}