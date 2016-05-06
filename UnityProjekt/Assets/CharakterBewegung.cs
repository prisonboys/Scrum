using UnityEngine;
using System.Collections;

public class CharacterBewegung : MonoBehaviour {
	public float laufgeschwindigkeit = 6.0F;
	public float Sprungstärke = 8.0F;
	public float Gravitation = 20.0F;
	public Vector3 Laufrichtung = Vector3.zero;
	
	
	
	// Update is called once per frame
	void Update () {
		float v = Input.GetAxis ("Vertical");
		float h = Input.GetAxis("Horizontal");
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
			Laufrichtung = new Vector3(h, 0, v);
			Laufrichtung = transform.TransformDirection(Laufrichtung);
			Laufrichtung *= laufgeschwindigkeit;
			if (Input.GetButton("Jump"))
				Laufrichtung.y = Sprungstärke;
			
		}
		Laufrichtung.y -= Gravitation * Time.deltaTime;
		controller.Move(Laufrichtung * Time.deltaTime);
	}
}