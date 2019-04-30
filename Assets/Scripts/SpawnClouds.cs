using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnClouds : MonoBehaviour
{
    	static public SpawnClouds S;
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
            float xMax = 400f;
            float zMin = -300f;
            float zMax = -20f;
            float yMin = 5f;
            float yMax = 80f;
    
            pos.x = Random.Range(xMin, xMax);
            
            pos.y = Random.Range(yMin, yMax);
    
            pos.z = Random.Range(zMin, zMax);
    
            spawnee.transform.position = pos;
            spawnee.transform.rotation = Quaternion.identity;
            rateSpawn = gameObject.GetComponent<Receive>().rot*7f;
            
            if(rateSpawn > 0.5){
                Invoke("SpawnStuff", 1f/rateSpawn);
            }
    
            Destroy(spawnee, 5.0f);
    
        }
    
        void Update(){
    
        	rateSpawn = gameObject.GetComponent<Receive>().rot*7f;
            //Awake();
            if(rateSpawn>0.5f && isAwake == false){
              Invoke("AwakeSpawn", 0.1f);
              isAwake = true;  
            }
    
            if(rateSpawn < 0.5f && isAwake == true){
                isAwake = false;
            }
    
            //if(rateSpawn == 0)
    
        }
    }
