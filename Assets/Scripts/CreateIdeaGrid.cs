using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateIdeaGrid : MonoBehaviour
{
    [SerializeField] public int N = 4;
    [SerializeField] public GameObject ideaSpace;
    [SerializeField] public List<Transform> ideas;

    [SerializeField] public GameObject ideaPrefab;

    void Start()
    {
        // Get spawn positions
        for (int i = 0; i < N; i++)
        {
            Transform idea = ideaSpace.transform.GetChild(i);
            ideas.Add(idea);
            Instantiate(ideaPrefab, idea.position, Quaternion.identity, idea);
        }
        Debug.Log("Spawn Grid created");

        // Instantiate the hidden ideas at the spawn positions
        


    }
}
