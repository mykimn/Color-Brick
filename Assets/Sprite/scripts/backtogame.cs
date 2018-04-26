using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backtogame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void regame()
    {
        GameObject.Find("Canvas1_1").transform.Find("pause").gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
