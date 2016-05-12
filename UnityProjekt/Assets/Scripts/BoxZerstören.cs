using UnityEngine;
using System.Collections;

public class BoxZerstören : MonoBehaviour {
	public GameObject Box;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerStay (Collider other) {
		if (other.tag == "Player") {


			if (Input.GetKey (KeyCode.E)) {
				Debug.Log ("player");
				Destroy (Box) ;

			}
		}
	
	}
}
