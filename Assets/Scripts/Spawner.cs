using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] Items;

	// Use this for initialization
	void Start () {
        StartCoroutine(Spawn());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator Spawn()
    {
        Vector3 temp = new Vector3(transform.position.x, Random.Range(-2.4f, 2.4f), 0);
        yield return new WaitForSeconds(Random.Range(1f, 1.5f));
        GameObject.Instantiate(Items[Random.Range(0, Items.Length)], temp, Quaternion.identity);
        StartCoroutine(Spawn());
    }
}
