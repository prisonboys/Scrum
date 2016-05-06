using UnityEngine;
using System.Collections;

public class Achse2Skript : MonoBehaviour {

	public GameObject player;
	public CharakterMovement cm;
	public float moveSpeed;
	
	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	
	
	void OnTriggerStay (Collider player)
	{
		cm = player.GetComponent<CharakterMovement> ();
		Debug.Log ("im trigger");
		if (Input.GetKey (KeyCode.B)) {
			Debug.Log("E gedrückt");
			cm.enabled = false;
			transform.parent.parent = player.transform;
			float v = Input.GetAxis ("Vertical");
			player.transform.Translate (new Vector3 (0, 0, v) * Time.deltaTime * moveSpeed);
		}
		else 
		{
			transform.parent.parent = null;
			cm.enabled = true;
		}
	}
	
}