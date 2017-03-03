using UnityEngine;
using System.Collections;

public class HiddenBox : MonoBehaviour {
//	public Material visibleMaterial;
//	public Material hiddenMaterial;

	[System.NonSerialized]
	public bool contact = false;

	[System.NonSerialized]
	public bool hidden = false;

	// Use this for initialization
	void Start ()
	{
//		renderer.material = visibleMaterial;
	}
	
	// Update is called once per frame
	void Update ()
	{
		hiddenBox ();

		/*string tag = gameObject.tag;

		switch (tag)
		{
		case "hiddenbox":
			hiddenBox ();
			break;
		case "hiddenhole":
			hiddenHole();
			Debug.Log("Visible: " + visibleMaterial);
			Debug.Log("Hidden: " + hiddenMaterial);
			break;
		}*/

		/*if (tag == "hiddenbox")
		{
			hiddenBox ();
		}*/

		/*Vision vision = GameObject.FindWithTag("MainCamera").GetComponent<Vision>();

		bool hidden = !vision.vision;
		float boxNo = vision.boxNo;
		float collideNo = vision.collideNo;
		float percent = 0f;

		if (boxNo != 0)
		{
			percent = collideNo / boxNo;
		}

		//Color colour = renderer.material.color;

		if (hidden)
		{
			if (percent >= 0.75f)
			{
				setVisiblility(percent/10);
				//colour.a = percent/10;
				//renderer.material.color = colour;
			}
			else
			{
				setVisiblility(0f);
				//colour.a = 0f;
				//renderer.material.color = colour;
			}
		}
		else
		{
			if (percent < 0.1f)
			{
				setVisiblility(0.1f);
				//colour.a = 0.1f;
				//renderer.material.color = colour;
			}
			else
			{
				setVisiblility(percent);
				//colour.a = percent;
				//renderer.material.color = colour;
			}
		}

		Debug.Log ("percent: " + percent);*/
		//Debug.Log ("renderer.material.color: " + renderer.material.color);
	}

	void setVisiblility(float alpha)
	{
		Color colour = renderer.material.color;

		colour.a = alpha;
		renderer.material.color = colour;

		//Debug.Log ("colour.a: " + colour.a);

	}

//	void setMaterial(Material m)
//	{
//		renderer.material = m;
//	}

	void hiddenBox()
	{
		Vision vision = GameObject.FindWithTag("MainCamera").GetComponent<Vision>();
		
		bool hidden = !vision.vision;
		float boxNo = vision.boxNo;
		float collideNo = vision.collideNo;
		float percent = 0f;
		
		string tag = gameObject.tag;
		string boxTag = "hiddenbox";
		string holeTag = "hiddenhole";
		
		if (boxNo != 0)
		{
			percent = collideNo / boxNo;
		}
		
		//Color colour = renderer.material.color;
		
		if (hidden)
		{
			//setMaterial(visibleMaterial);
			
			if (percent >= 0.75f)
			{
				if (tag == boxTag)
				{
					setVisiblility(percent/10);
				}
				else if(tag == holeTag)
				{
					setVisiblility(1 - percent/10);
				}
				
				//colour.a = percent/10;
				//renderer.material.color = colour;
			}
			else
			{
				if (tag == boxTag)
				{
					setVisiblility(0f);
				}
				else if(tag == holeTag)
				{
					setVisiblility(1f);
				}

				//colour.a = 0f;
				//renderer.material.color = colour;
			}
		}
		else
		{
			//setMaterial(visibleMaterial);
			
			if (percent < 0.1f)
			{
				if (tag == boxTag)
				{
					setVisiblility(0.1f);
				}
				else if(tag == holeTag)
				{
					setVisiblility(1 - 0.1f);
				}

				//colour.a = 0.1f;
				//renderer.material.color = colour;
			}
			else
			{
				if (tag == boxTag)
				{
					setVisiblility(percent);
				}
				else if(tag == holeTag)
				{
					setVisiblility(1 - percent);
				}

				//colour.a = percent;
				//renderer.material.color = colour;
			}
		}
		
		//Debug.Log ("percent: " + percent);
	}

	/*void hiddenHole()
	{
		Vision vision = GameObject.FindWithTag("MainCamera").GetComponent<Vision>();
		
		bool hidden = !vision.vision;
		float boxNo = vision.boxNo;
		float collideNo = vision.collideNo;
		float percent = 0f;
		
		if (boxNo != 0)
		{
			percent = collideNo / boxNo;
		}
		
		//Color colour = renderer.material.color;
		
		if (hidden)
		{
			setMaterial(visibleMaterial);

			if (percent >= 0.75f)
			{
				setVisiblility(1 - percent/10);
				//colour.a = percent/10;
				//renderer.material.color = colour;
			}
			else
			{
				setVisiblility(1f);
				//colour.a = 0f;
				//renderer.material.color = colour;
			}
		}
		else
		{
			setMaterial(visibleMaterial);

			if (percent < 0.1f)
			{
				setVisiblility(1 - 0.1f);
				//colour.a = 0.1f;
				//renderer.material.color = colour;
			}
			else
			{
				setVisiblility(1 - percent);
				//colour.a = percent;
				//renderer.material.color = colour;
			}
		}
	}*/
}