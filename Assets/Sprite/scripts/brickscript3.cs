using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class brickscript3 : MonoBehaviour
{
    public static int SCORE = 0;
    public int[] array2 = new int[4] { 0, 0, 0, 0 };
    public Color32 RED = new Color32(234, 27, 91, 255);
    public Color32 BLUE = new Color32(43, 43, 188, 255);
    public Color32 YELLOW = new Color32(247, 235, 28, 255);
    public Color32 GREEN = new Color32(37, 206, 61, 255);
    public int count = 0;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Application.platform == RuntimePlatform.Android){
            if(Input.GetKey (KeyCode.Escape)){
                GameObject.Find("Canvas1_1").transform.Find("pause").gameObject.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ball")
        {
            Destroy(gameObject);
            if (gameObject.GetComponent<SpriteRenderer>().color == RED)
            {
                scorelimit.instance.AddScore(-5);
                scorelimit.instance.Check(3);
            }
            else if (gameObject.GetComponent<SpriteRenderer>().color == GREEN)
            {
                scorelimit.instance.AddScore(10);
                scorelimit.instance.Check(3);
            }
            else if (gameObject.GetComponent<SpriteRenderer>().color == YELLOW)
            {
                scorelimit.instance.AddScore(5);
                scorelimit.instance.Check(3);
            }
            else if (gameObject.GetComponent<SpriteRenderer>().color == BLUE)
            {
                scorelimit.instance.AddScore(7);
                scorelimit.instance.Check(3);
            }
        }
    }
}
