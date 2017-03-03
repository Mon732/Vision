using UnityEngine;
using System.Collections;

public class CollisionDetect : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.tag == "Player")
		{
			HiddenBox hiddenbox = transform.parent.gameObject.GetComponent<HiddenBox> ();
			hiddenbox.contact = true;
		}

		Debug.Log(c.gameObject.tag + " Collision!");
	}
}
