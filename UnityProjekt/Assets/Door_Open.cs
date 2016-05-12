using UnityEngine;
using System.Collections;

public class Door_Open : MonoBehaviour {
	
	public bool Open;
	private BoxCollider coll;
	private MeshRenderer render;
	// Use this for initialization
	void Start () {
		coll = GetComponent<BoxCollider> ();
		render = GetComponent<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Open == true) {
			coll.enabled = false;
			render.enabled = false;
			
		} 
		else {
			coll.enabled = true;
			render.enabled = true;
		}
	}
}
