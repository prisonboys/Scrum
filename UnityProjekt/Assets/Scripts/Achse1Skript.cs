using UnityEngine;
using System.Collections;

public class Achse1Skript : MonoBehaviour {

	public GameObject player;
	public GameObject cube;			//parent object des empty, das geschoben werden soll
	private CharakterMovement cm;
	public float moveSpeed;


	void Start () {
		cm = player.GetComponent<CharakterMovement> ();
	
	}
		
		void OnTriggerStay (Collider other)
		{
		if (Input.GetKey (KeyCode.B) & other.tag == "Player") {
			Debug.Log("B gedrückt");
			cm.enabled = false;
			cube.transform.parent = player.transform;
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
