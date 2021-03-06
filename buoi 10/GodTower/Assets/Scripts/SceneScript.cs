﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneScript : MonoBehaviour
{



	public Text levelText;
	public InputField inputfield;
	public Button submitButton;
	public Text hintText;
	public Button changeSceneButton;
	public AudioClip clip;

	public string levelContent = "LEVEL";
	public string levelNumber;
	public string levelAnswer;
	public string destination;




	string answer;

	// Use this for initialization
	void Start ()
	{
		levelText.text = levelContent;
		StartCoroutine (changeLevelTextRoutine ());
		changeSceneButton.gameObject.SetActive (false);

	}

	public void getInput ()
	{
		AudioSource.PlayClipAtPoint (clip,Vector3.zero);
		answer = inputfield.text;
		checkAnswer (answer);
	}

	public void checkAnswer (string answer)
	{
		if (answer.ToLower () == levelAnswer) {
			hintText.text = "Access granted.";
			hintText.color = Color.green;
			changeSceneButton.gameObject.SetActive (true);

			//todo: CHANGE SCENE
		} else {
			hintText.text = "Access denied.";
			hintText.color = Color.red;
			inputfield.text = "";
			inputfield.ActivateInputField ();
		}
	}


	IEnumerator changeLevelTextRoutine ()
	{
		while (true) { 
			levelText.text = levelContent;
			//wait 2s
			yield return new WaitForSeconds (2f);
			levelText.text = levelNumber;
			yield return new WaitForSeconds (2f);

		}
	}

	public void changeScene ()
	{		
		SceneManager.LoadScene (destination);

	}


	// Update is called once per frame
	void Update ()
	{
		
	}
}
