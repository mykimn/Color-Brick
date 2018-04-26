using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Ballscipt : MonoBehaviour {

    public Rigidbody2D rb1;
    public float ballForse;
    bool gameStarted = false;
    public int cnt = 0;
	// Use this for initialization
    void Awake()
    {
        //Screen.SetResolution(800, 1280, true);
    }
	void Start () {
	}

    // Update is called once per frame
    void Update()
    {
        if (cnt == 0)
        {
            if (Input.GetMouseButton(0) && gameStarted == false)
            {
                transform.SetParent(null);
                rb1.isKinematic = false;
                rb1.AddForce(new Vector2(ballForse, ballForse));
                gameStarted = true;
                cnt = 1;
            }
        }
    }
}
