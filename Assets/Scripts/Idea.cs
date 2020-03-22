using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Idea : MonoBehaviour
{
    [SerializeField] public Transform parent; 
    [SerializeField] public GameObject ideaPrefab;
    [SerializeField] public Vector3 spawnPos;
    public void Spawn()
    {
        spawnPos = parent.transform.Find("Spawn").position;
        GameObject obj = Instantiate(ideaPrefab, spawnPos, Quaternion.identity, parent);


        // Change color hue to random value
        Color color = obj.transform.Find("Boarder").GetComponent<Image>().color;
        // First convert from RGB to HSV
        float H, S, V;
        Color.RGBToHSV(color, out H, out S, out V);
        //Debug.Log(H + ", " + S + ", " + V);
        H = Random.Range(0.0f, 1f);
        //Debug.Log(H + ", " + S + ", " + V);

        // Then convert back to RGB and asign it to the boarder
        obj.transform.Find("Boarder").GetComponent<Image>().color = Color.HSVToRGB(H, S, V);

        Debug.Log("Idea spawned");
    }


}
