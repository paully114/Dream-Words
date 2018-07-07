using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMScript : MonoBehaviour
{

	public static string currentWord;
	public Transform spelledWord;
	//spublic KeyCode RMB;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		spelledWord.GetComponent<TextMesh>().text = currentWord;

		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
		{
			Debug.Log("asdasd");
		}
	}
}
