using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level4Blacked : MonoBehaviour {

	public Image barImage;
	void Start(){
		Color firstColor = barImage.color;
		firstColor.a = 0;
		barImage.color = firstColor;

		barImage = GetComponent<Image> ();

	}

	public void OnPointerEnter(){
		Color tempColor = barImage.color;
		tempColor.a = 1;

		barImage.color = tempColor;
	}

	public void OnPointerExit(){
		Color tempColor = barImage.color;
		tempColor.a = 0;

		barImage.color = tempColor;
	}
}
