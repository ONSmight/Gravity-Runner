using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    public float speed = 3f;


    void Update()
    {
        Vector3 temp;
        temp = transform.position;
        temp.x -= speed * Time.deltaTime;
        transform.position = temp;
    }
}
