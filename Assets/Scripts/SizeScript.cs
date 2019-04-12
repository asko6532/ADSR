using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeScript : MonoBehaviour {
 
	private float yTrans;
	public int cNum;
	public float scale = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	if(cNum == 0)
		yTrans = (float)gameObject.GetComponent<Receive>().c1;
	else if(cNum == 1)
		yTrans = (float)gameObject.GetComponent<Receive>().c2;
	else if(cNum == 2)
		yTrans = (float)gameObject.GetComponent<Receive>().c3;
	else if(cNum == 3)
		yTrans = (float)gameObject.GetComponent<Receive>().c4;

		transform.localScale = new Vector3 (scale, yTrans, scale);
	}
}
