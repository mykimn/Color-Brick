using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveball : MonoBehaviour {
    public Vector2 minpos;
    public Vector2 maxpos;

    private Transform ballTf;
    private Vector3 ballpos;
    private Vector2 movevalue;
    private float movespeed = 8f;

    void Awake()
    {
        ballTf = transform;
        ballpos = ballTf.position;
        movevalue = Vector2.one;
    }
    void FixedUpdate()
    {
        ballpos.x += movespeed * movevalue.x;
        ballpos.y += movespeed * movevalue.y;
        if (ballpos.x < minpos.x)
        {
            movevalue.x *= 1;
            ballpos.x += minpos.x - ballpos.x;
        }
        else if (ballpos.x > maxpos.y)
        {
            movevalue.x *= -1;
            ballpos.x += maxpos.x - ballpos.x;
        }
        if (ballpos.y < minpos.y)
        {
            movevalue.y *= -1;
            ballpos.y += minpos.y - ballpos.y;
        }
        else if (ballpos.y > maxpos.y)
        {
            movevalue.y *= -1;
            ballpos.y += maxpos.y - ballpos.y;
        }
        ballTf.position = ballpos;
    }
}
