using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IdeaButton : MonoBehaviour
{
    GameManager GM;
    public int ideas = 0;
    
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();

        GM.OnIdeaCreated += delegate (object sender, EventArgs e)
        {
            UpdateIdeaButton();
        };
    }

    public void UpdateIdeaButton()
    {
        if (ideas + 1 <= 7)
        {
            ideas += 1;
        }        
        transform.GetChild(ideas).gameObject.SetActive(true);
    }

    public void Disable(GameObject obj)
    {
        if (ideas - 1 >= 0)
        {
            ideas -= 1;
        }        
        obj.SetActive(false);  
    }
}
