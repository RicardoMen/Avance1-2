using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletcontroller : MonoBehaviour {

public GameObject gunPos;
public GameObject bulletpref;
public float velocidadBala;
float newfire=0;
Rigidbody2D myrig;
	// Use this for initialization
	void Start () {
		myrig=GetComponent<Rigidbody2D>();
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Mouse0))
		{
			GameObject nuevodisparo = Instantiate(bulletpref,gunPos.transform.position,Quaternion.identity);
			nuevodisparo.GetComponent<Rigidbody2D>().velocity=direccion*velocidadBala;
			
		}
		
	}
}
