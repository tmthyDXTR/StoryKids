using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevealIdea : MonoBehaviour
{
    GameManager GM;

    private IdeaCloud IC;
    public GameObject item;

    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        IC = this.GetComponent<IdeaCloud>();
    }

    // Types: animal, mood, ....
    public void Reveal(GameObject itemContainer, string type)
    {
        itemContainer.transform.Find("Reveal_Button").gameObject.SetActive(false);
        
        if (type == "animal")
        {
            int N = IC.animals.Count;
            int randomIndex = Random.Range(0, N);

            GameObject it = Instantiate(item, itemContainer.transform.position, Quaternion.identity, itemContainer.transform) as GameObject;
            it.GetComponent<Image>().sprite = IC.animals[randomIndex];
            Debug.Log("Animal revealed");
        }

        if (type == "mood")
        {
            int N = IC.moods.Count;
            int randomIndex = Random.Range(0, N);

            GameObject it = Instantiate(item, itemContainer.transform.position, Quaternion.identity, itemContainer.transform) as GameObject;
            it.GetComponent<Image>().sprite = IC.moods[randomIndex];
            it.GetComponent<Image>().color = new Color(0, 188, 195);
            Debug.Log("Mood revealed");
        }

        GM.AddRevealedIdea();
    }
}