using UnityEngine;
using System.Collections;

public class SchiebungVertical : MonoBehaviour {
	public GameObject player;
	public float moveSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float v = Input.GetAxis ("Vertical");
		player.transform.Translate (new Vector3 (0, 0, v) * Time.deltaTime * moveSpeed);
	
	}
}
