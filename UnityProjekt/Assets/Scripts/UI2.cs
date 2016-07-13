using UnityEngine;
using System.Collections;

public class UI2 : MonoBehaviour {


	public GameObject Hier;
	public GameObject Next;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Return)) {
			Next.SetActive (true);
			Hier.SetActive (false);
		}
	}
}