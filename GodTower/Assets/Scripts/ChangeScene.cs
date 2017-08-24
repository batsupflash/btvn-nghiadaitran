using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour {

	public Button beginButton;

	public string destination;
	// Use this for initialization
	void Start () {
		
	}
	public void changeScene(){
		Application.LoadLevel (destination);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
