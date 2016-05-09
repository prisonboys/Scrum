using UnityEngine;
using System.Collections;

public class AchseVerticalSkript : MonoBehaviour {
	public GameObject player;
	public CharakterMovement cm;
	public float moveSpeed;
	public GameObject Achse1;
	public bool Achse2Aktiv = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerStay (Collider player)
	{
		cm = player.GetComponent<CharakterMovement> ();
		Debug.Log ("im trigger");
		if (Input.GetKey (KeyCode.B)) {
			Achse2Aktiv = true;
			cm.enabled = false;
			transform.parent.parent = player.transform;
			float v = Input.GetAxis ("Vertical");
			player.transform.Translate (new Vector3 (0, 0, v) * Time.deltaTime * moveSpeed);
		} else {
			Achse2Aktiv = false;
			if (!Achse1.GetComponent<Achse1Skript> ().Achse1Aktiv) {
				transform.parent.parent = null;
				cm.enabled = true;
			}
		}
	}
}
