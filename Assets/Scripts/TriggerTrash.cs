using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTrash : MonoBehaviour
{
    public Idea I;
    public IdeaButton ideaBtn;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Mood")
        {
            Debug.Log("Mood in Trash");
            I.Spawn("mood");
        }

        if (other.tag == "Idea")
        {
            ideaBtn.UpdateIdeaButton();
        }
    }
}
