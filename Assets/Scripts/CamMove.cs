using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour {

    float speed=3f;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 temp;
        temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;
	}
}
