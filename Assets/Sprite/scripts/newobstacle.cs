using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newobstacle : MonoBehaviour {
    public float obstacle = 0f;
    float Ttime = 0f;
    public GameObject newob;
	// Use this for initialization
	void Start () {
        obstacle = Random.Range(404f,2055f);
	}
	
	// Update is called once per frame
	void Update () {
        Ttime += Time.deltaTime;
        if (Ttime > 0.8f)
        {
            transform.position = new Vector3(obstacle, 0, 0);
            Instantiate(newob, transform.position, transform.rotation);
            obstacle = Random.Range(404f, 2055f);
            Ttime = 0f;
        }
    }
}
