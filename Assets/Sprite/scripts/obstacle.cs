using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour {
    public int highLevel = 0;
    float height;

    Transform obsTf;
    void Awake()
    {
        obsTf = transform;
    }
    public void SetObstacle(int lv)
    {
        Vector3 tempVec = new Vector3(1440f, 130, 1f);
        obsTf.localScale = tempVec;
    }
}
