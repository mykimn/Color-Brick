﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorelimit : MonoBehaviour {
    public static scorelimit instance; //어디서나 접근할 수 있도록 static(정적)으로 자기 자신을 저장할 변수를 만듭니다.
    public Text scoreText; //점수를 표시하는 Text객체를 에디터에서 받아옵니다.
    private int score = 0; //점수를 관리합니다.
    public static int count = 0;
    private int mycheck;
    void Start()
    {
        scoreText = GameObject.Find("score").GetComponent<Text>();
        scoreText.text = "SCORE :  "+score.ToString();
    }
    void Awake()
    {
        if (!instance) //정적으로 자신을 체크합니다.
            instance = this; //정적으로 자신을 저장합니다.
    }
    public void AddScore(int num) //점수를 추가해주는 함수를 만들어 줍니다.
    {
        score += num; //점수를 더해줍니다.
        scoreText.text = "SCORE :   " + score.ToString(); //텍스트에 반영합니다.

        if (score >= 60)
        {
            GameObject.Find("Canvas1_1").transform.Find("nextstage").gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void Check(int num)
    {
        switch (num)
        {
            case 1: mycheck = 25; break;
            case 2: mycheck = 30; break;
            case 3: mycheck = 35; break;
            case 4: mycheck = 40; break;
        }
        mycheck -= 1;
        if (mycheck == 0)
        {
            GameObject.Find("Canvas1_1").transform.Find("gameoverpanel").gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void Update()
    {

    }
}