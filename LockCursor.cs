using UnityEngine;
using System.Collections;

public class LockCursor : MonoBehaviour {
	[System.NonSerialized]
	public bool keyboardEnabled = true;

	// Use this for initialization
	void Start ()
	{
		enableMouseLook(false);
		enableKeyboard(false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.Escape))
		{
			Screen.lockCursor = false;
			enableMouseLook(false);
			enableKeyboard(false);
		}

		if (keyboardEnabled)
		{

		}
	}

	//Locks the cursor and enables mouseLook
	void OnMouseDown()
	{
		Screen.lockCursor = true;
		enableMouseLook (true);
		enableKeyboard(true);

		Debug.Log ("Click");
	}

	//Enables/Disables the MouseLook scripts attached to player and MainCamera.
	void enableMouseLook(bool t)
	{
		Debug.Log ("Enable MouseLook: " + t);

		Component cmp = GameObject.FindWithTag ("Player").GetComponent ("MouseLook");
		(cmp as MouseLook).enabled = t;


		cmp = GameObject.FindWithTag ("MainCamera").GetComponent ("MouseLook");
		(cmp as MouseLook).enabled = t;

		cmp = GameObject.FindWithTag ("MainCamera").GetComponent ("Vision");
		(cmp as Vision).enabled = t;
	}

	void enableKeyboard(bool t)
	{
		Component cmp = GameObject.FindWithTag ("Player").GetComponent ("CharacterMotorC");
		(cmp as CharacterMotorC).canControl = t;
		keyboardEnabled = t;


		Debug.Log ("cmp: " + cmp);
	}
}