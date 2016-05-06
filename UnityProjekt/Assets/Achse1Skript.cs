using UnityEngine;
using System.Collections;

public class Achse1Skript : MonoBehaviour {

	public GameObject player;
	public GameObject Boden;
	public CharakterMovement cm;
	public float moveSpeed;

	// Use this for initialization
	void Start () {
		cm = player.GetComponent<CharakterMovement> ();
	
	}
	
	// Update is called once per frame

	
		void OnTriggerStay (Collider player)
		{

		Debug.Log ("im trigger");
		if (Input.GetKey (KeyCode.B)) {
			Debug.Log("E gedrückt");
			cm.enabled = false;
			transform.parent.parent = player.transform;
			float h = Input.GetAxis ("Horizontal");
			player.transform.Translate (new Vector3 (h, 0, 0) * Time.deltaTime * moveSpeed);
		}
		else 
		{
			transform.parent.parent = null;
			cm.enabled = true;
		}
	}

}
