using UnityEngine;
using System.Collections;

public class GUISchieben : MonoBehaviour {


	public GameObject pfeil;


	void OnTriggerStay (Collider other) 
	{
		if (other.tag == "Player") {
			pfeil.active = true; 
		}
	}
	void OnTriggerExit (Collider other)
	{
		if (other.tag == "Player") {
			pfeil.active = false;
		}
	}
}
