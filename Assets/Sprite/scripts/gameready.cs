using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameready : MonoBehaviour {
    public GameObject readyText;
    public static gameready instance;
    public int count = 0;
    void Awake()
    {
        if (gameready.instance == null)
            gameready.instance = this;
    }
	// Use this for initialization
	void Start () {
        readyText.SetActive(false);
        StartCoroutine(ShowReady());
	}
    IEnumerator ShowReady()
    {
        while (count < 3)
        {
            readyText.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            readyText.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            count++;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
