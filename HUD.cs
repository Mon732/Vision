using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		LockCursor lockcursor = GameObject.FindWithTag("GameController").GetComponent<LockCursor>();
		bool keyboardEnabled = lockcursor.keyboardEnabled;

		if (keyboardEnabled)
		{
			Component cmp = GameObject.FindWithTag ("percent").GetComponent ("GUIText");
			Vision vision = GameObject.FindWithTag ("MainCamera").GetComponent<Vision> ();

			float boxNo = vision.boxNo;
			float collideNo = vision.collideNo;
			float percent = Mathf.FloorToInt((collideNo / boxNo) * 100);

			(cmp as GUIText).text = "Percent: " + percent + "%";

			//Debug.Log ("boxNo" + boxNo);
			//Debug.Log ("collideNo" + collideNo);
			//Debug.Log ("percent" + percent);
		}
	}
}