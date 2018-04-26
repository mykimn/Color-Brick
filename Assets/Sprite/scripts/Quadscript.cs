using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quadscript : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D col) //Box Collider 설정을 받아와
    {

        if (col.gameObject.tag == "Ball")  //충돌이 Ball이면 
        {
            if (GameObject.Find("like1").GetComponent<SpriteRenderer>())
            {
                SpriteRenderer r = GameObject.Find("like1").GetComponent<SpriteRenderer>();
                Destroy(r);//하트
                //_ball.transform.position = new Vector2(0.136f, -2.104f);
                
            }
            else if(GameObject.Find("like2").GetComponent<SpriteRenderer>())
            {
                SpriteRenderer r1 = GameObject.Find("like2").GetComponent<SpriteRenderer>();
                Destroy(r1);//하트
                //_ball.transform.position = new Vector2(0.136f, -2.104f);
            }
            else if (GameObject.Find("like3").GetComponent<SpriteRenderer>())
            {
                SpriteRenderer r2 = GameObject.Find("like3").GetComponent<SpriteRenderer>();
                Destroy(r2);//하트
                //_ball.transform.position = new Vector2(0.136f, -2.104f);
            }
            else if (GameObject.Find("like4").GetComponent<SpriteRenderer>())
            {
                SpriteRenderer r3 = GameObject.Find("like4").GetComponent<SpriteRenderer>();
                Destroy(r3);//하트
                //_ball.transform.position = new Vector2(0.136f, -2.104f);
            }
            else
            {
                SpriteRenderer r4 = GameObject.Find("like5").GetComponent<SpriteRenderer>();
                Destroy(r4);//하트
                GameObject.Find("Canvas1_1").transform.Find("gameoverpanel").gameObject.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}

