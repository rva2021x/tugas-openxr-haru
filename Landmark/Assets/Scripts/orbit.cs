using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit : MonoBehaviour {

	// Variable Declaration
	public GameObject bubble;
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		OrbitAround();
	}

	void OrbitAround()
	{
		transform.RotateAround(bubble.transform.position, Vector3.up, speed * Time.deltaTime);
	}
}
