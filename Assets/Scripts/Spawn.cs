using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	static public Spawn S;
	public GameObject[] prefabs;
	public GameObject spawnScript;
    bool isAwake = false;

	public float rateSpawn;
    //private float rate;

	// Use this for initialization
	private void AwakeSpawn(){
        S = this;
        //rateSpawn = gameObject.GetComponent<Receive>().r;
        Invoke("SpawnStuff", 0.1f);
    }
	

	public void SpawnStuff(){

        

		int ndx = Random.Range(0, prefabs.Length);
        
        GameObject spawnee = Instantiate<GameObject>(prefabs[ndx]);

        Vector3 pos = new Vector3(-12.0f, 20.0f, -23.2f);
        float xMin = -50f;
        float xMax = 50f;
        float zMin = -40f;
        float zMax = 8f;

        pos.x = Random.Range(xMin, xMax);

        pos.z = Random.Range(zMin, zMax);

        spawnee.transform.position = pos;
        spawnee.transform.rotation = Quaternion.identity;
        rateSpawn = gameObject.GetComponent<Receive>().r;
        
        if(rateSpawn > 0.5){
            Invoke("SpawnStuff", 1f/rateSpawn);
        }

        Destroy(spawnee, 5.0f);

    }

    void Start(){

    }
    void Update(){

    	rateSpawn = gameObject.GetComponent<Receive>().r;
        //Awake();
        if(rateSpawn>0.5f && isAwake == false){
          Invoke("AwakeSpawn", 0.1f);
          isAwake = true;  
        }

        if(rateSpawn < 0.5f && isAwake == true){
            isAwake = false;
        }

        //if(rateSpawn == 0)
        
        Debug.Log("SPAWN RATE:" + rateSpawn);
        Debug.Log("one over SR" + 1f/rateSpawn);

    }
}
