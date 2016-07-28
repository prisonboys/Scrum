using UnityEngine;
using System.Collections;

public class SchiebungHorizontal : MonoBehaviour {
	public GameObject player;
	public float moveSpeed = 2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal");
		player.transform.Translate (new Vector3 (h, 0, 0) * Time.deltaTime * moveSpeed);
	
	}
}
