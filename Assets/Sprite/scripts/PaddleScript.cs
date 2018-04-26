/*using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{

    public Rigidbody2D rb1;
    public float speed;
    public static Vector2 zero;
    public float maxX;
    
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float x = Input.GetAxis("Horizontal");

        if (x < 0)
        {
            Moveleft();
        }
        if(x > 0)
        {
            Moveright();
        }
        if(x ==0)
        {
            Stop();
        }
        Vector2 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x,-maxX,maxX);
        transform.position = pos;
    }

    void Moveleft()
    {
        rb1.velocity = new Vector2(-speed, 0);

    }
    void Moveright()
    {
        rb1.velocity = new Vector2 (speed,0);
    }
    void Stop()
    {
        rb1.velocity = Vector2.zero;
    }*/
    /*public GameObject paddle;
    private Vector3 initMousePos;

    public float maxX;

    private void OnMouseDown()
    {
        initMousePos = Input.mousePosition;
        initMousePos.z = 10;
        initMousePos = Camera.main.ScreenToWorldPoint(initMousePos);
    }

    void OnMouseDrag()
    {
        Vector3 worldPoint = Input.mousePosition;
        worldPoint.z = 10;
        worldPoint = Camera.main.ScreenToWorldPoint(worldPoint);

        Vector3 diffPos = worldPoint - initMousePos;
        diffPos.z = 0;
        diffPos.y = 0;

        initMousePos = Input.mousePosition;
        initMousePos.z = 10;
        initMousePos = Camera.main.ScreenToWorldPoint(initMousePos);

        paddle.transform.position =
            new Vector3(Mathf.Clamp(paddle.transform.position.x + diffPos.x, -4f, 4f),
                        paddle.transform.position.y,
                        paddle.transform.position.z);

        Vector2 pos = transform.position;

        //pos.x = Mathf.Clamp(pos.x, -maxX, maxX);
        transform.position = pos;
    }
}*/


using UnityEngine;
using System.Collections;
 
public class PaddleScript : MonoBehaviour
{
    public GameObject _dragon;
    private Vector3 initMousePos;  
 
    //처음마우스 클릭시
    void OnMouseDown()
    {
        initMousePos = Input.mousePosition;
        initMousePos.z = 10;
        initMousePos = Camera.main.ScreenToWorldPoint(initMousePos);   
 
        //Debug.Log("mouse Down : " + initMousePos);
    }
    //마우스 드래그시
    void OnMouseDrag()
    {
        Vector3 worldPoint = Input.mousePosition;
        worldPoint.z = 10;
        worldPoint = Camera.main.ScreenToWorldPoint(worldPoint);   
 
        Vector3 diffPos = worldPoint - initMousePos;
        diffPos.z = 0;
        diffPos.y = 0;
 
        initMousePos = Input.mousePosition;
        initMousePos.z = 10;
        initMousePos = Camera.main.ScreenToWorldPoint(initMousePos);
 
        _dragon.transform.position =
            new Vector3(Mathf.Clamp(_dragon.transform.position.x + diffPos.x, -6f, 6f),
                        _dragon.transform.position.y,
                        _dragon.transform.position.z);
 
 
    //  Debug.Log("mouse drag" + diffPos);
    }
}
