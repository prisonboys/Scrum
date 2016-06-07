using UnityEngine;
using System.Collections;

public class KIscript : MonoBehaviour {
	public Transform[] ziele;
	public int Ziel = 0;
	public string Hauptmenu;
	NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		NeuesZiel ();
	}
	
	// Update is called once per frame
	void Update () {
		if (agent.remainingDistance < 0.3) {
			NeuesZiel ();
		}
		}
	void NeuesZiel (){
		//if (ziele.Length == 0) {
		//	return;
		//}
		agent.SetDestination (ziele[Ziel].position);
		if (Ziel > 2) {
			Ziel =0;
		}
		else {
		Ziel = Ziel + 1;
		}
	}
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			Application.LoadLevel (Hauptmenu);
		}
	}
}
