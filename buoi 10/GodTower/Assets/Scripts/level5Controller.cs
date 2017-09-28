using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class level5Controller : EventTrigger
{
	Image thisImage;
	Vector3 offSet;



	void Start ()
	{

		thisImage = GetComponent<Image> ();

		float x = Random.Range (-228, 228);
		float y = Random.Range (-146, 141);
		float z = transform.localPosition.z;
		transform.localPosition = new Vector3 (x, y, z);

		thisImage.alphaHitTestMinimumThreshold = 0.5f;
	}

	public override void OnBeginDrag (PointerEventData data)
	{
		
		Vector3 screenMousePos = Input.mousePosition;

		Vector3 worldSpaceMousePos= Camera.main.ScreenToWorldPoint (screenMousePos);

		Vector3  canvasMousePos = transform.parent.InverseTransformPoint (worldSpaceMousePos);

		offSet = canvasMousePos - transform.localPosition;


	}

	public override void OnDrag (PointerEventData data)
	{

		Vector3 worldSpaceMousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);

		Vector3 canvasMousePos = transform.parent.InverseTransformPoint (worldSpaceMousePos);

	
		Vector3 expectedImagePos = canvasMousePos - offSet;

		transform.localPosition = new Vector3 (
			Mathf.Clamp (expectedImagePos.x, -228, 228),
			Mathf.Clamp (expectedImagePos.y, -146, 141),
			transform.localPosition.z);
	}
}
