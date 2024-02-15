using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour {
    float width;
    // Use this for initialization
    void Start () {
        width = GameObject.Find("BG").GetComponent<BoxCollider2D>().size.x;
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "BG" || target.gameObject.tag == "Ground")
        {
            Vector3 temp;
            temp = target.transform.position;
            temp.x += width * 3;
            target.transform.position = temp;
        }

        if (target.gameObject.tag == "Rocket")
        {
            Destroy(target.gameObject);
        }
    }


    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Coin")
        {
            Destroy(target.gameObject);
        }
    }

}
