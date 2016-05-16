using UnityEngine;
using System.Collections;

public class PressEnterGUI : MonoBehaviour 
{
	public GameObject Title;
	public GameObject Menu;

	void Update () 
	{
		if (Input.anyKey) 
		{
			Title.active = false;
			Menu.active = true;
		}	
	}
}
