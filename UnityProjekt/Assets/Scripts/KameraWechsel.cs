using UnityEngine;
using System.Collections;

public class KameraWechsel : MonoBehaviour {
	public GameObject TopKam;
	public GameObject IsoKam;
	public bool TopKamActive = false;

	// Use this for initialization
	void Start () {
		TopKam.SetActive(false);
		IsoKam.SetActive(true);

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			if (TopKamActive == false) {
				TopKam.SetActive(true);
				IsoKam.SetActive(false);
				TopKamActive = true;
			} else {
				TopKam.SetActive(false);
				IsoKam.SetActive(true);
				TopKamActive = false;
			}
		}
	}
}
