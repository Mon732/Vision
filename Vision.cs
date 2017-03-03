using UnityEngine;
using System.Collections;

public class Vision : MonoBehaviour {
	[System.NonSerialized]
	public bool vision = false;

	bool canVision = true;

	[System.NonSerialized]
	public int boxNo = 0;

	[System.NonSerialized]
	public int collideNo = 0;
	
	HiddenBox[] obj;
	GameObject overlay;



	// Use this for initialization
	void Start ()
	{
		obj = FindObjectsOfType<HiddenBox>();
		boxNo = obj.Length;

		overlay = GameObject.FindWithTag("overlay");

		Debug.Log("boxNo: " + boxNo);
	}
	
	// Update is called once per frame
	void Update ()
	{
		collideNo = 0;

		foreach (HiddenBox element in obj)
		{
			if (element.contact)
			{
				collideNo++;
			}
		}

		//Debug.Log ("collideNo: " + collideNo);

		if(Input.GetMouseButtonDown(1))
		{
			if (canVision)
			{
			setVision(true);

			Invoke("clearVision",1.5f);

			Debug.Log("Seeing all");
			}
		}
		else if(Input.GetMouseButtonUp(1))
		{
			setVision(false);

			CancelInvoke("clearVision");
			Invoke("regainVision",0.5f);

			Debug.Log("I am blind");
		}
	}

	void setVision(bool t)
	{
		vision = t;
		setOverlay(t);
	}

	void clearVision()
	{
		vision = false;
		setOverlay(false);
		canVision = false;
	}

	void regainVision()
	{
		canVision = true;
	}

	void setOverlay(bool t)
	{
		Color colour = overlay.guiTexture.color;

		if (t)
		{
			colour.a = 0.05f;
			overlay.guiTexture.color = colour;
		}
		else
		{
			colour.a = 0;
			overlay.guiTexture.color = colour;
		}
	}
}
