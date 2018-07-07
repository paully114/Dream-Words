using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private int letterChecker = 0;
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "O")
		{
			
		}
		
	}
	
	
}
