using UnityEngine;
using System.Collections;

public class schiebeskript : MonoBehaviour {

	public GameObject player;
	// Use this for initialization
	public GameObject nix;
	void Start () {

	}
	void OnTriggerStay(Collider other)
	{

		if (Input.GetKey(KeyCode.E) & other.tag == "Player")
		{
			
			this.transform.parent = player.transform;
			
			Debug.Log("E gedrückt");
		}
		else 
		{
			this.transform.parent = nix.transform;
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
	
}