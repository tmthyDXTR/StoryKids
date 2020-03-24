using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookManager : MonoBehaviour
{
    public bool bookOpened = false;

    public List<GameObject> bookItems;

    public Transform bookTransform;


    void Start()
    {
        bookTransform = GameObject.Find("Content").transform;
    }

    public void OpenCloseBook()
    {
        if (bookOpened)
        {
            Debug.Log("Close Book");
            bookOpened = false;
        }
        else if (!bookOpened)
        {
            Debug.Log("Open Book");
            bookOpened = true;
        }
    }

    public void AddIdeaToBook(GameObject obj)
    {
        bookItems.Add(obj);
        obj.transform.SetParent(bookTransform);
        obj.GetComponent<Rigidbody2D>().simulated = false;
        obj.transform.Find("Item(Clone)").GetComponent<DragHandler>().enabled = false;
        Debug.Log("Idea added to book");

        
        /////
    }
}
