﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickHiddenIdea : MonoBehaviour
{
    public GameObject ideaManager;

    public RevealIdea RI;

    public string[] ideaTypes;
    public string type; // animal, mood, icon, job...
    void Start()
    {
        ideaManager = GameObject.Find("IdeaManager");

        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        RI = ideaManager.GetComponent<RevealIdea>();

        if (this.transform.parent.tag != "Mood")
        {
            ideaTypes = new string[3] { "animal", "icon", "job" };
            int randIndex = (int)Random.Range(0f, 3f);
            type = ideaTypes[randIndex];
        }        
        else
        {
            type = "mood";
        }
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the Reveal Button!");

        RI.Reveal(this.transform.parent.gameObject, type);
    }
}
