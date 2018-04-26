using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class barscript : MonoBehaviour {

    public Image image;
    float t = 0.0f;
    void update()
    {
        t += Time.deltaTime;
        if( t > 1f ) 
        {
            float fill = image.fillAmount;
        if( fill < 1f ) 
        { 
            fill -= 0.1f; 
            t = 0; 
        } 
        else 
        { 
            fill = 0f; 
        } 
    } 
    }
}
