using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class first : MonoBehaviour {
    public GameObject laserPrefab; //발사할 레이저를 저장합니다.
    public bool canShoot = true; //레이저를 쏠 수 있는 상태인지 검사합니다.
    const float shootDelay = 0.5f; //레이저를 쏘는 주기를 정해줍니다.
    float shootTimer = 0; //시간을 잴 타이머를 만들어줍니다.
    Color[] array = new Color[] { Color.blue,Color.red,Color.yellow };
    static int i=0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Shooting () {
        if (GameObject.Find("ball").GetComponent<Image>().color != array[i])
        {
            if (canShoot)
            {
                if (shootTimer > shootDelay && Input.GetMouseButtonDown(0))
                {
                    Instantiate(laserPrefab, transform.position, Quaternion.identity); //레이저를 생성해줍니다.
                    shootTimer = 0; //쿨타임을 다시 카운트 합니다.
                }
                shootTimer += Time.deltaTime; //쿨타임을 카운트 합니다.
            }
        }
        else
        {

        }
        i++;
	}
}
