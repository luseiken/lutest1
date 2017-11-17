﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
	public float speed=0.03f;
	public float jump=1.5f;
	// Use this for initialization
	void Start () {
		Debug.Log ("HELLO");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("w"))
		{
			GetComponent<Rigidbody>().AddForce(new Vector3(0,0,speed));
		}
		if (Input.GetKey ("s"))
		{
			GetComponent<Rigidbody>().AddForce(new Vector3(0,0,-speed));
		}
		if (Input.GetKey ("a"))
		{
			GetComponent<Rigidbody>().AddForce(new Vector3(-speed,0,0));
		}
		if (Input.GetKey ("d"))
		{
			GetComponent<Rigidbody>().AddForce(new Vector3(speed,0,0));
		}
		if (Input.GetKeyDown ("space"))
		{
			GetComponent<Rigidbody>().AddForce(new Vector3(0,jump,0));
		}
	}
}
