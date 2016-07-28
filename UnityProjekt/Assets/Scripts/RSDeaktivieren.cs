using UnityEngine;
using System.Collections;

public class RSDeaktivieren : MonoBehaviour {

	public GameObject Player;
	public RutschScript rs;
	public CharakterMovement cm;

	void OnTriggerStay(Collider other) {
		if (other.tag == "Player") {
			cm.enabled = true;
			rs.enabled = false;
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.tag == "Player") {
			cm.enabled = false;
			rs.enabled = true;
		}
	}
}
