using UnityEngine;
using System.Collections;

public class PlayerRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W)){
			transform.localEulerAngles = new Vector3(0,0+45,0);
		}
		if (Input.GetKeyDown (KeyCode.A)){
			transform.localEulerAngles = new Vector3(0,270+45,0);
		}
		if (Input.GetKeyDown (KeyCode.S)){
			transform.localEulerAngles = new Vector3(0,180+45,0);
		}
		if (Input.GetKeyDown (KeyCode.D)){
			transform.localEulerAngles = new Vector3(0,90+45,0);
		}
	
	}
}
