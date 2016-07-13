using UnityEngine;
using System.Collections;

public class RutschScript : MonoBehaviour {
	public float moveSpeed = 3;
	public float v;
	public float h;
	public bool still = false;
	public Vector3 Laufrichtung = Vector3.zero;
	public CharacterController Controller;
	public GameObject Player;
	public float Sprungstärke = 4.0F;
	public float Gravitation = 20.0F;
	public float CurPosx;
	public float CurPosz;
	public float LastPosx;
	public float LastPosz;



	// Use this for initialization
	void Start () {
		Controller = GetComponent<CharacterController> ();

	}
	
	// Update is called once per frame
	void Update () {
		CurPosx = Player.transform.position.x;
		CurPosz = Player.transform.position.z;


		if (CurPosx==LastPosx&&CurPosz==LastPosz)
		{
			still=true;
			Debug.Log("Still true");
		}
		else {
			still=false;
			Debug.Log("still false");
		}
		LastPosx = Player.transform.position.x;
		LastPosz = Player.transform.position.z;
		Laufrichtung = new Vector3(h, 0, v);
		if (still == true) {

			Debug.Log("Beweg");

			if (Input.GetKeyDown (KeyCode.W)) {
				v = 0.1f;
				h = 0;
			}
			if (still = true && Input.GetKeyDown (KeyCode.S)) {
				v = -0.1f;
				h = 0;
			}
			if (still = true && Input.GetKeyDown (KeyCode.A)) {
				v = 0;
				h = -0.1f;
			}
			if (Input.GetKeyDown (KeyCode.D)) {
				v = 0;
				h = 0.1f;
			}
			if (Controller.isGrounded && Input.GetButton("Jump")) {
				Laufrichtung.y = Sprungstärke/2;
			}

		}
		else {	
			Debug.Log("NB");
			
		}
		Laufrichtung = transform.TransformDirection(Laufrichtung);
		Laufrichtung.y -= Gravitation * Time.deltaTime;
		Controller.Move(Laufrichtung * moveSpeed * Time.deltaTime);
	
	}
  void	OnTriggerEnter (Collider other){
			v = 0;
			h = 0;
	}
}
