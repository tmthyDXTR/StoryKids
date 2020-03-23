using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameTime : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    private float startTime;
    void Start()
    {
        timerText = this.gameObject.GetComponent<TextMeshProUGUI>();
        startTime = Time.time;
    }

    void Update()
    {
        float t = Time.time - startTime;
        timerText.text = t.ToString("f0");

        
    }

}
