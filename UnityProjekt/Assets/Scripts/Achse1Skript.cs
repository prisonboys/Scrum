using UnityEngine;
using System.Collections;

public class Achse1Skript : MonoBehaviour {

	public GameObject player;
	public GameObject Achse2;
	public CharakterMovement cm;
	public float moveSpeed;
	public bool Achse1Aktiv = false;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame

	
		void OnTriggerStay (Collider player)
		{
		cm = player.GetComponent<CharakterMovement> ();
	
		if (Input.GetKey (KeyCode.B)) {

			Achse1Aktiv = true;
			cm.enabled = false;
			transform.parent.parent = player.transform;
			float h = Input.GetAxis ("Horizontal");
			player.transform.Translate (new Vector3 (h, 0, 0) * Time.deltaTime * moveSpeed);

		} else {
			Achse1Aktiv = false;
			if (!Achse2.GetComponent<AchseVerticalSkript> ().Achse2Aktiv) {
				transform.parent.parent = null;
				cm.enabled = true;
			}
		}
	}

}
