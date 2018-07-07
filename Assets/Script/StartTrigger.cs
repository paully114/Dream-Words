using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTrigger : MonoBehaviour
{


	public GameObject txtObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Player")
		{
			txtObject.SetActive(true);
		}
	}
	
	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.name == "Player")
		{
			txtObject.SetActive(false);
		}
	}
}
