using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHead : MonoBehaviour {

	GameObject player;// Use this for initialization
	void Start () {
		player = GameObject.Find("player");
	}
	
	// Update is called once per frameu
	void Update () {
		transform.position = player.transform.position + transform.forward;
	}
}
