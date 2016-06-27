using UnityEngine;
using System.Collections;

public class RutschScriptAktivieren : MonoBehaviour {
	public GameObject Player;
	public RutschScript rs;
	public CharakterMovement cm;
	// Use this for initialization
	void Start () {
		cm = Player.GetComponent<CharakterMovement> ();
		rs = Player.GetComponent<RutschScript> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider other){
		if (other.tag == "Player") {
			cm.enabled = false;
			rs.enabled = true;
		}
	}
	void OnTriggerExit (Collider other){
		if (other.tag == "Player") {
			cm.enabled = true;
			rs.enabled = false;
		}
	}

}
