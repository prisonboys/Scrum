using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour 
{ 
	public void LoadScene(string sceneName) 
	{ 
		Application.LoadLevel(sceneName); 
	} 
}
