using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickHiddenIdea : MonoBehaviour
{
    public GameObject ideaManager;

    public RevealIdea RI;

    public string type; // animal, mood, ...
    void Start()
    {
        ideaManager = GameObject.Find("IdeaManager");

        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        RI = ideaManager.GetComponent<RevealIdea>();
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the Reveal Button!");

        RI.Reveal(this.transform.parent.gameObject, type);
    }
}
