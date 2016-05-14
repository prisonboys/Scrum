using UnityEngine;
using System.Collections;

public class GUIExit : MonoBehaviour {

	public GameObject symbol;


	void OnTriggerStay (Collider other) 
	{
		if (other.tag != "Player") {
			symbol.active = false; 
		}
	}
	void OnTriggerExit (Collider other)
	{
		if (other.tag != "Player") {
			symbol.active = true;
		}
	}
}
