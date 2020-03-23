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

    // Types: animal, mood, icon ....
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

        if (type == "icon")
        {
            int N = IC.icons.Count;
            int randomIndex = Random.Range(0, N);

            GameObject it = Instantiate(item, itemContainer.transform.position, Quaternion.identity, itemContainer.transform) as GameObject;
            it.GetComponent<Image>().sprite = IC.icons[randomIndex];
            Debug.Log("Icon revealed");
        }

        if (type == "job")
        {
            int N = IC.jobs.Count;
            int randomIndex = Random.Range(0, N);

            GameObject it = Instantiate(item, itemContainer.transform.position, Quaternion.identity, itemContainer.transform) as GameObject;
            it.GetComponent<Image>().sprite = IC.jobs[randomIndex];
            it.transform.localScale = new Vector3(1.4f, 1.4f, 0);
            it.transform.position += new Vector3(15f, 0, 0);
            Debug.Log("Job revealed");
        }

        GM.AddRevealedIdea();
    }
}