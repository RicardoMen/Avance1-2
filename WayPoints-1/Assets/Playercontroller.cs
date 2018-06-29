using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		mouseface();
	}
	void mouseface(){
		Vector3 mousepos= Input.mousePosition;
		mousepos=Camera.main.ScreenToWorldPoint(mousepos);

		Vector2 direction = new Vector2(mousepos.x-transform.position.x,mousepos.y-transform.position.y);
		transform.up=direction;
	}
}
