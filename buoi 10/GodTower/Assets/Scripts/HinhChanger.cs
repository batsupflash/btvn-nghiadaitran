using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HinhChanger : MonoBehaviour {

	public Button hintButton;
	public List<Image> hintsList;

	int hintCurrentIndex = 0;

	public void OnHintButtonClick ()
	{
		hintCurrentIndex++;
		if (hintCurrentIndex == hintsList.Count - 1) {
			hintButton.transform.localScale = new Vector3 (-1, 1, 1);
		} else {
			hintButton.transform.localScale = new Vector3 (1, 1, 1);
		}

		if (hintCurrentIndex == hintsList.Count) {
			hintCurrentIndex = 0;
		}
		//		hintButton.transform.localScale Vector



		for (int i = 0; i < hintsList.Count; i++) {
			if (i == hintCurrentIndex) {
				hintsList [i].gameObject.SetActive (true);
			} else {
				hintsList [i].gameObject.SetActive (false);
			}
		}
	}
	//	public Button toHintSceneButton;
	//	public string hintDestination;

	//	int hintCurrentIndex =1;
	//public Image hint1;
	//public Image hint2;
	//
	//	//public GameObject hint3;
	//	public void onHintButtonClick(){
	//		if (hintCurrentIndex == 1) {
	//			hint1.gameObject.SetActive (false);
	//			hint2.gameObject.SetActive (true);
	//			hintCurrentIndex = 2;
	//		} else if (hintCurrentIndex == 2) {
	//			hint1.gameObject.SetActive (true);
	//			hint2.gameObject.SetActive (false);
	//		}

	//c2


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
