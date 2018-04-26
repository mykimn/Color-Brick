﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class timelimit : MonoBehaviour {
    public GameObject obj;
    public static float time;
    private Text text;
	// Use this for initialization
	void Start () {
        time = 60f;
        Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {
       if (time != 0)
       {
           time -= Time.deltaTime;
           if (time <= 0)
           {
             time = 0;
           }
       }
       else
       {
           GameObject.Find("Canvas1_1").transform.Find("gameoverpanel").gameObject.SetActive(true);
           Time.timeScale = 0;
       }
    int t = Mathf.FloorToInt(time);
    Text uiText = GetComponent<Text>();
    uiText.text = "TIME  :  "+t.ToString();
	}
}