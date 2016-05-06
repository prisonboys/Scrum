using UnityEngine;
using System.Collections;

public class schiebeskript : MonoBehaviour {

	public GameObject player;
	// Use this for initialization
	public GameObject nix;
	void Start () {

	}
	void OnTriggerStay(Collider player)
	{

		if (Input.GetKey(KeyCode.E))
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