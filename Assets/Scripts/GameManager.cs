using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public int ideasRevealed;
    public EventHandler OnIdeasRevealedChanged;


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
}
