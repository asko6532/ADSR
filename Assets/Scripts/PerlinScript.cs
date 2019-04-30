using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinScript : MonoBehaviour {

	 //noise deform stuff
    float NoiseScale = 0.5f;
    float speed = 0.8f;
    bool recalculateNormals = false;
    private Mesh mesh;
    private float intensity = 0.0f;
    
    public int objNum = 0;

    private Vector3[] baseVertices;
    private Perlin noise;


    private Vector3[] vertices;


	// Use this for initialization
	void Start () {
		 //noise stuff
        noise = new Perlin ();
        mesh = this.GetComponent<MeshFilter>().mesh;
       
        

        //Debug.Log(mesh);
		
	}
	
	// Update is called once per frame
	void Update () {

		intensity = (float)gameObject.GetComponent<Receive>().n;

		
        //noise stuff

        float scale = NoiseScale * intensity;

        
        if(baseVertices == null){
            baseVertices = mesh.vertices;
        }

        vertices = new Vector3[baseVertices.Length];

        var timex = Time.time * speed + 0.1365143f;
        var timey = Time.time * speed + 1.21688f;
        var timez = Time.time * speed + 2.5564f;

        for(int i=0; i<vertices.Length; i++){
            var vertex = baseVertices[i];
        
            vertex.x += noise.Noise(timex + vertex.x, timex + vertex.y, timex + vertex.z) * scale;
            vertex.y += noise.Noise(timey + vertex.x, timey + vertex.y, timey + vertex.z) * scale;
            vertex.z += noise.Noise(timez + vertex.x, timez + vertex.y, timez + vertex.z) * scale;

            vertices[i] = vertex;

        
        }

        mesh.vertices = vertices;
        
        if(recalculateNormals){ 
            mesh.RecalculateNormals();
        }
        mesh.RecalculateBounds();
	}
}
