using UnityEngine;
using System.Collections;

public class CharakterMovement : MonoBehaviour {
	
	public float laufgeschwindigkeit = 4.0F;
	public float Sprungstärke = 4.0F;
	public float Gravitation = 20.0F;
	public float Renngeschwindigkeit = 5.0f;
	public Vector3 Laufrichtung = Vector3.zero;
	public bool Achse1 = false;
	public bool Achse2 = false;

	
	
	// Update is called once per frame
	void Update () {

		float v = Input.GetAxis ("Vertical");
		float h = Input.GetAxis("Horizontal");
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
			Laufrichtung = new Vector3(h, 0, v);
			Laufrichtung = transform.TransformDirection(Laufrichtung);
			
			
			if (Input.GetKey (KeyCode.LeftShift)) {
				Laufrichtung *= Renngeschwindigkeit;
				
			}
			else {
				Laufrichtung *= laufgeschwindigkeit;
				
			}
			if (Input.GetButton("Jump")){
				Laufrichtung.y = Sprungstärke;
			
			}
			}
		Laufrichtung.y -= Gravitation * Time.deltaTime;
		controller.Move(Laufrichtung * Time.deltaTime);
		if (Achse1==true) {
			Debug.Log ("klappt alles");
				
		}
	}
}
