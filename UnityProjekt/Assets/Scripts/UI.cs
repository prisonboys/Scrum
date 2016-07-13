using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {

	public GameObject Next;
	public GameObject Textbox;
	public int n=0;
	public int z;

	void Update(){
		if(Input.GetKeyDown (KeyCode.Return))
		{
			n++;
		}
		if (n == z) {
			Next.SetActive(true);
			Textbox.SetActive (false);
		}
			
	}
}
