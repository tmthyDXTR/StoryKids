using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColourFade : MonoBehaviour
{
    public Image image;
    public float H, S, V;

    public int cycleSpeed = 60;

    void Start()
    {
        image = this.gameObject.GetComponent<Image>();


        // Change color hue to random value
        Color color = image.color;
        // First convert from RGB to HSV        
        Color.RGBToHSV(color, out H, out S, out V);

        Debug.Log(H + ", " + S + ", " + V);

        H = Random.Range(0f, 1f);
        // Then convert back to RGB and asign it to the boarder
        image.color = Color.HSVToRGB(H, S, V);
    }

    void Update()
    {
        float lerpedHue = Mathf.PingPong(Time.time/ cycleSpeed, 1f);
        //Debug.Log(lerpedHue);
        image.color = Color.HSVToRGB(lerpedHue, S, V);
    }
}
