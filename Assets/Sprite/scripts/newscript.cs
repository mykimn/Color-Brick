using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newscript : MonoBehaviour {
    public static float time;
	// Use this for initialization
	void Start () {
        time = 2f;
        Time.timeScale = 0;
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
            GameObject.Find("Canvas1_1").transform.Find("paneltouch").gameObject.SetActive(false);
            Time.timeScale = 1;
        }
	}
}
