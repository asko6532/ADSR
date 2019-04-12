using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChanger : MonoBehaviour {

	public float amtRed = 0.8784314f;
	Light lt;

	// Use this for initialization
	void Start () {
		lt = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		amtRed = 0.8784314f - (float)gameObject.GetComponent<Receive>().m3;
		lt.color = new Color(amtRed, 0.2980392f, 0.3921569f, 1f);
	}
}
