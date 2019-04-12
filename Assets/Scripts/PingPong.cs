using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour {

	public float minSize = 3.0f;
	//public float posZ = 6.0f;
	//public float endPosX = -15f;
	//public float endPosZ = -20f;
	public float range = 3f;
	private float rate = 13f;
	public int num = 0;
	public int posZ = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	if(num == 0){
		range = 4.0f - (float)gameObject.GetComponent<Receive>().p;
		transform.position = new Vector3((Mathf.Sin(Time.time * rate) + 1.0f) / 2.0f * range + minSize, transform.position.y, transform.position.z);
	}
	if(num == 1){
		rate = 9f;
		range = (float)gameObject.GetComponent<Receive>().mtnShake * 3f;
		transform.position = new Vector3((Mathf.Sin(Time.time * rate) + 1.0f) / 2.0f * range + minSize, transform.position.y, posZ);
	}
	}


}
