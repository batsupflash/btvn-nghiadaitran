using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSCript : MonoBehaviour
{

	public float moveSpeed = 2;
	public int distance = 10;

	// Use this for initialization
	void Start ()
	{
		StartCoroutine (MoveToRight ());
	}

	IEnumerator MoveToRight ()
	{
		float distanceMoved = 0f;
		while (distanceMoved < distance) {
			transform.position = new Vector3 (transform.position.x + moveSpeed * Time.deltaTime,
				transform.position.y,
				transform.position.z);
			distanceMoved += moveSpeed * Time.deltaTime;

			yield return null;

		}
	}
	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKeyDown (KeyCode.A)) {
			Debug.Log ("A pressed");
		}

		if (Input.GetKey (KeyCode.B)) {
			Debug.Log ("B pressed");
		}

		if (Input.GetKeyUp (KeyCode.D)) {
			Debug.Log ("D pressed");

		}

	}
}
