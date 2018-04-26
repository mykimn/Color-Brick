using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ballitem : MonoBehaviour {
    public static ballitem instance;
    //public int[] array = new int[4] { 0, 0, 0, 0 };
    public int count = 0;
    public int count1 = 0;
    public int count2 = 0;
    public Color32 RED = new Color32(234, 27, 91, 255);
    public Color32 BLUE = new Color32(43, 43, 188, 255);
    public Color32 YELLOW = new Color32(247, 235, 28, 255);
    public Color32 GREEN = new Color32(37, 206, 61, 255);
    int color;
    Color newcolor;
	// Use this for initialization
	void Start () {
       color = Random.Range(0, 4);
       switch (color)
       {
           case 0: { newcolor = RED; break; } // 빨간색
           case 1: { newcolor = BLUE; count++; break; }// 파란색
           case 2: { newcolor = YELLOW; count1++; break; }// 노란색
           case 3: { newcolor = GREEN; count2++; break; } // 초록색
       }
       GameObject.Find(this.name).GetComponent<SpriteRenderer>().color = newcolor;
 
      // GameObject.Find(a).GetComponent<Image>().color = newcolor;
	}
	// Update is called once per frame
	void Update () {

	}
}
