using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotChange : MonoBehaviour {

	public float speed = 0f;
	private float range = 0f;
	// Use this for initialization
	void Start () {
		Invoke("Shake", 1f);
	}
	
	// Update is called once per frame
	void Update () {
		speed = 1.0f  - (float)gameObject.GetComponent<Receive>().rot + 0.1f;
		range = 3f *(float)gameObject.GetComponent<Receive>().rot;
	}

	void Shake(){
		transform.rotation = new Quaternion(Random.Range(-range, range), -20f, Random.Range(-range, range), 0f);
		Invoke("Shake", speed);
	}
}
