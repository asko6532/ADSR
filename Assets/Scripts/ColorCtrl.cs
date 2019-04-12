using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCtrl : MonoBehaviour {

    public Color color = Color.white;
    public Renderer rend;



	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Renderer>().material.color = new Color (color.r,color.g,color.b,color.a);
        rend = this.GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {


		rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_Color", color);

        color.g = (float)gameObject.GetComponent<Receive>().m;
        color.r = (float)gameObject.GetComponent<Receive>().m2;
        color.b = (float)gameObject.GetComponent<Receive>().m3*3.0f;

	}
}
