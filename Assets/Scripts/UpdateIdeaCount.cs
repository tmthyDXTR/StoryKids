using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class UpdateIdeaCount : MonoBehaviour
{
    GameManager GM;

    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();

        GM.OnIdeasRevealedChanged += delegate (object sender, EventArgs e)
        {
            UpdateIdeaCounter();
        };
    }

    private void UpdateIdeaCounter()
    {
        transform.GetComponent<TextMeshProUGUI>().text = GM.ideasRevealed.ToString();
    }
}
