using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HomeDebugText : MonoBehaviour
{
    public TextMeshProUGUI TMP;

    void Start()
    {
        TMP.text = "Version " + Application.version;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
