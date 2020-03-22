using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateIdeaGrid : MonoBehaviour
{
    [SerializeField] public int N = 4;
    [SerializeField] public GameObject ideaSpace;
    [SerializeField] public List<Transform> ideaPositions;

    [SerializeField] public GameObject ideaPrefab;
    [SerializeField] public Idea idea;
    void Start()
    {
        idea = GetComponent<Idea>();
        // Get spawn positions
        for (int i = 0; i < N; i++)
        {
            idea.Spawn();

        }
        Debug.Log("Spawn Grid created");     
    }
}
