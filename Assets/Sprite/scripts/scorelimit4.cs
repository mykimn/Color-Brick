﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorelimit4 : MonoBehaviour
{
    public static scorelimit4 instance; //어디서나 접근할 수 있도록 static(정적)으로 자기 자신을 저장할 변수를 만듭니다.
    public Text scoreText; //점수를 표시하는 Text객체를 에디터에서 받아옵니다.
    private int score = 0; //점수를 관리합니다.
    public static int count = 0;
    private int mycheck = 40;
    void Start()
    {
        scoreText = GameObject.Find("score").GetComponent<Text>();
        scoreText.text = "SCORE :  " + score.ToString();
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
    public void Check()
    {
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
