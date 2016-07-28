using UnityEngine;
using System.Collections;

public class Schieben1 : MonoBehaviour {

	public GameObject player;
	public GameObject Achse2;
	public CharakterMovement cm;
	public SchiebungHorizontal sh;
	public SchiebungVertical sv; 
	public bool Achse1Aktiv = false;
	public bool ImTrigger = false;

	// Use this for initialization
	void Start () {
		cm = player.GetComponent<CharakterMovement> ();
		sh = player.GetComponent<SchiebungHorizontal> ();


	}

	// Update is called once per frame


	void OnTriggerEnter (Collider other)

	{
		if (other.tag == "Player") {
			ImTrigger = true;
			Debug.Log("trigger Enter");
		}

	}
	void OnTriggerExit (Collider other) {
		if (other.tag == "Player") {
			ImTrigger = false;
			cm.enabled = true;
			sh.enabled = false;
			Debug.Log("trigger leave");
			transform.parent.parent = null;
		}

	}


	void Update () {
		if ( ImTrigger ==true){
			if (Input.GetKey (KeyCode.B)) {

				Achse1Aktiv = true;
				cm.enabled = false;
				sh.enabled = true;
				transform.parent.parent = player.transform;


			} else {
				Achse1Aktiv = false;
				if (!Achse2.GetComponent<Schieben2> ().Achse2Aktiv) {
					transform.parent.parent = null;
					cm.enabled = true;
					sh.enabled = false;
				}
			}
		}
	}
}