using UnityEngine;
using System.Collections;

public class IngameMenu : MonoBehaviour {
	private bool istPausiert = false;
	public GameObject IngameMenuCanvas;
	public string Hauptmenu;
	public GameObject player;
	public float X;
	public float Y;
	public float Z;
		// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (istPausiert) {
			IngameMenuCanvas.SetActive (true);
			Time.timeScale = 0;
		}
		if (!istPausiert) {
			IngameMenuCanvas.SetActive (false);
			Time.timeScale = 1;
		}
	if (Input.GetKeyDown (KeyCode.Escape)) {
			istPausiert = !istPausiert;
		}
	}
	public void Weiter (){
		istPausiert = false;
	}
	public void LetzterCheckpoint (){

		Application.LoadLevel (Application.loadedLevelName);
		istPausiert = false;
			
	}
	public void ZumHauptmenu () {
		Application.LoadLevel (Hauptmenu);
	}
	public void Speichern () {
		PlayerPrefs.SetString ("level", Application.loadedLevelName);
	}

}
