using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    IdeaButton ideaBtn;

    public int ideasRevealed;
    public EventHandler OnIdeasRevealedChanged;

    public float ideaWait = 20f;
    public EventHandler OnIdeaCreated;
    public bool waitForIdea = true;

    

    void Update()
    {
        if (waitForIdea)
        {
            StartCoroutine(AddNewIdea());
        }
    }

    public void AddRevealedIdea()
    {
        Score.ideasRevealed += 1;
        ideasRevealed = Score.ideasRevealed;
        if (OnIdeasRevealedChanged != null) OnIdeasRevealedChanged(null, EventArgs.Empty);
    }

    public void ResetScores()
    {
        Score.ideasRevealed = 0;
        if (OnIdeasRevealedChanged != null) OnIdeasRevealedChanged(null, EventArgs.Empty);

    }

    IEnumerator AddNewIdea()
    {
        waitForIdea = false;
        yield return new WaitForSeconds(ideaWait);        
        Debug.Log("New Idea");
        waitForIdea = true;
        if (OnIdeaCreated != null) OnIdeaCreated(null, EventArgs.Empty);

    }
}
