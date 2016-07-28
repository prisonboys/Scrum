using UnityEngine;
using System.Collections;

public class DrehKI : MonoBehaviour {
    public float Drehgeschwindigkeit = 10f;
    public GameObject KI;
    public bool Drehrichtung = false; //false heißt auf 90grad zubewegen true heißt auf 270//
	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        if (Drehrichtung == false)
        {
            if (transform.rotation.eulerAngles.y < 90)
            {
                Drehrichtung = true;

            }
        }
        if (Drehrichtung == true)
        {
            if (transform.rotation.eulerAngles.y > 270)
            {
                Drehrichtung = false;
            }
        }

        if (Drehrichtung == false) {
            transform.Rotate(Vector3.up, Drehgeschwindigkeit * Time.deltaTime * -1);
            

        }
        else
        {
            transform.Rotate(Vector3.up, Drehgeschwindigkeit * Time.deltaTime);

        }
	}
}
