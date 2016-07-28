using UnityEngine;
using System.Collections;

public class Schieben2 : MonoBehaviour{
	public GameObject player;
	public GameObject Achse1;
	public CharakterMovement cm;
	public SchiebungVertical sv; 
	public SchiebungHorizontal sh;
	public bool ImTrigger = false;
	public bool Achse2Aktiv = false;


	// Use this for initialization
	void Start () {
		cm = player.GetComponent<CharakterMovement> ();
		sv = player.GetComponent<SchiebungVertical> ();

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
			sv.enabled = false;
			Debug.Log("trigger leave");
			transform.parent.parent = null;
		}

	}

	void Update (){
		{
			if ( ImTrigger ==true){
				if (Input.GetKey (KeyCode.B)) {
					Achse2Aktiv = true;
					cm.enabled = false;
					sv.enabled = true;
					transform.parent.parent = player.transform;
				}
				else {
					Achse2Aktiv = false;
					if (!Achse1.GetComponent<Schieben1> ().Achse1Aktiv) {
						transform.parent.parent = null;
						cm.enabled = true;
						sv.enabled = false;
					}
				}
			}
		}
	}
}

