using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Experimental.GlobalIllumination;

public class Receive : MonoBehaviour {

	public OSC osc;

    public float m;
    public float m2;
    public float n;
    public float r;
    public float c1;
    public float c2;
    public float c3;
    public float c4;
    public float m3;
    public float p;
    public float rot;
    public float mtnShake;

 
    
    

	void Start () {
        //address handlers
		osc.SetAddressHandler("/Data1", OnReceiveData1);
        osc.SetAddressHandler("/Data2", OnReceiveData2);
        osc.SetAddressHandler("/Data3", OnReceiveData3);
        osc.SetAddressHandler("/Data4", OnReceiveData4);
        osc.SetAddressHandler("/Data5", OnReceiveData5);
        osc.SetAddressHandler("/Data6", OnReceiveData6);
        osc.SetAddressHandler("/Data7", OnReceiveData7);
        osc.SetAddressHandler("/Data8", OnReceiveData8);
        osc.SetAddressHandler("/Data9", OnReceiveData9);
        osc.SetAddressHandler("/Data10", OnReceiveData10);
        osc.SetAddressHandler("/Data11", OnReceiveData11);
        osc.SetAddressHandler("/Data12", OnReceiveData12);



       
	}
	
	void Update () {
        

	}




    void OnReceiveData1(OscMessage message) {
        m = message.GetFloat(0);
        //color.g = (float)m;
        //Debug.Log("received data1");
    }
    
    void OnReceiveData2(OscMessage message) {
        m2 = message.GetFloat(0);
        //color.r = (float)m2;
        //Debug.Log("received data2");
    }
    
    void OnReceiveData3(OscMessage message) {
        n = message.GetFloat(0);
        
    }

    void OnReceiveData4(OscMessage message) {
        r = (float)message.GetFloat(0);
    }

    void OnReceiveData5(OscMessage message) {
        c1 = (float)message.GetFloat(0);
    }
    
    void OnReceiveData6(OscMessage message) {
        c2 = (float)message.GetFloat(0);
    }
    
    void OnReceiveData7(OscMessage message) {
        c3 = (float)message.GetFloat(0);
        
    }

    void OnReceiveData8(OscMessage message) {
        c4 = (float)message.GetFloat(0);
    }
   
   void OnReceiveData9(OscMessage message) {
        m3 = (float)message.GetFloat(0);
    }

    void OnReceiveData10(OscMessage message) {
        p = (float)message.GetFloat(0);
    }

    void OnReceiveData11(OscMessage message) {
        rot = (float)message.GetFloat(0);
    }

    void OnReceiveData12(OscMessage message) {
        mtnShake = (float)message.GetFloat(0);
    }



    
}
