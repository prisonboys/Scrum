using UnityEngine;
using System.Collections;

public class Levelwechsel : MonoBehaviour {
    public string NeuesLevel;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter (Collider other)
    {
        Application.LoadLevel(NeuesLevel);
    }
}
