using UnityEngine;
using System.Collections;

public class Achse2Skript : MonoBehaviour {

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