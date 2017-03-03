using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {
	public string objTag;

	GameObject spawnPoint;


	// Use this for initialization
	void Start ()
	{
		spawnPoint = GameObject.FindWithTag (objTag);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter(Collider c)
	{
		Debug.Log("Collision: " + c);

		if (c.gameObject.tag == "Player")
		{
			c.gameObject.transform.position = spawnPoint.transform.position;
			c.gameObject.transform.rotation = spawnPoint.transform.rotation;;
		}
	}
}
