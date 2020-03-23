using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdeaCloud : MonoBehaviour
{
    public int animalsN = 16;
    [SerializeField] public List<Sprite> animals;

    public int moodsN = 9;
    [SerializeField] public List<Sprite> moods;


    public int iconsN = 60;
    [SerializeField] public List<Sprite> icons;

    public int jobsN = 100;
    [SerializeField] public List<Sprite> jobs;

    void Start()
    {
        // Load all moods into idea cloud
        for (int i = 1; i <= moodsN; i++)
        {
            Sprite icon = Resources.Load <Sprite> ("mood_" + i.ToString());
            moods.Add(icon);
        }

        // Load all icons into idea cloud
        for (int i = 1; i <= iconsN; i++)
        {
            Sprite icon = Resources.Load <Sprite> ("Icons/512/RoundIcons-Free-Set-" + i.ToString());
            icons.Add(icon);
        }

        // Load all job icons into idea cloud
        for (int i = 1; i <= jobsN; i++)
        {
            Sprite icon = Resources.Load <Sprite>("Jobs/" + i.ToString());
            jobs.Add(icon);
        }
    }
}
