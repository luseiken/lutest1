using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHead : MonoBehaviour {

	// Use this for initialization
    public float speed=0.03f;
	public float jump=1.5f;
	void Start () {
		
	}
	
	// Update is called once per frameu
	void Update () {
		
		if (Input.GetKey ("w"))
		{
			GetComponent<Rigidbody>().velocity+=transform.forward*(0.25f+speed);
		}
		if (Input.GetKey ("s"))
		{
			GetComponent<Rigidbody>().velocity-=transform.forward*(0.25f+speed);
		}
		if (Input.GetKey ("a"))
		{
			GetComponent<Rigidbody>().velocity+=new Vector3(-0.25f+speed,0,0);
		}
		if (Input.GetKey ("d"))
		{
			GetComponent<Rigidbody>().velocity+=new Vector3(0.25f+speed,0,0);
		}
		if (Input.GetKeyDown ("space"))
		{
			GetComponent<Rigidbody>().AddForce(new Vector3(0,30+jump,0));
		}
		if (Input.GetKey ("e"))
		{
			transform.Rotate (0, 1, 0);
		}
		if (Input.GetKey ("q"))
		{
			transform.Rotate (0, -1, 0);
		}
	}
}
