using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausescript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void reload(){
         GameObject.Find("Canvas1_1").transform.Find("pause").gameObject.SetActive(true);
         Time.timeScale = 0;
    }
}
