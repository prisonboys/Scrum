using UnityEngine;
using System.Collections;

public class CheckpointSkript : MonoBehaviour {
	public float PosX;
	public float PosY;
	public float PosZ;
	public GameObject Checkpoint;

	// Use this for initialization
	void Start () {
		PosX = Checkpoint.transform.position.x;
		PosY = Checkpoint.transform.position.y;
		PosZ = Checkpoint.transform.position.z;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter () {

		Debug.Log (PosX);
		Debug.Log (PosY);
		Debug.Log (PosZ);
		PlayerPrefs.SetFloat ("X", PosX); //hier eintragen an welcher position der spieler spawnen soll, vor dem Levelwechsel
		PlayerPrefs.SetFloat ("Y", PosY);
		PlayerPrefs.SetFloat ("Z", PosZ);
		Debug.Log (PlayerPrefs.GetFloat ("Z"));
	}
}
