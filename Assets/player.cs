﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	public float speed=0.03f;
	// Use this for initialization
	void Start () {
		Debug.Log ("HELLO");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("w"))
		{
			transform.position +=	new Vector3(0,0,speed);
		}
		if (Input.GetKey ("s"))
		{
			transform.position +=	new Vector3(0,0,-speed);
		}
		if (Input.GetKey ("a"))
		{
			transform.position +=	new Vector3(-speed,0,0);
		}
		if (Input.GetKey ("d"))
		{
			transform.position +=	new Vector3(speed,0,0);
		}
	}
}