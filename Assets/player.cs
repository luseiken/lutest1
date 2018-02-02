using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

GameObject head;

	// Use this for initialization
	void Start () {
		Debug.Log ("HELLO");
		head = GameObject.Find("head");
	}
	
	// Update is called once per frame
	void Update () {
 transform.position = head.transform.position - transform.forward;
		
	}
}
