using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startSceneScript : MonoBehaviour {


	// Use this for initialization
	public string defination;
	public void changeScene(){
		SceneManager.LoadScene (defination);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
