using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public BookManager BM;
    
    private Vector3 openPos;
    private Vector3 closePos;

    public float speed;

    void Start()
    {
        BM = GameObject.Find("BookManager").GetComponent<BookManager>();

        // Remember original position
        openPos = this.transform.position;
        closePos = this.transform.position -= new Vector3((Screen.width / 2), 0, 0);
        // Move out of screen to the left
        transform.position = closePos;
    }

    void Update()
    {
        if (BM.bookOpened)
        {
            // The step size is equal to speed times frame time.
            var step = speed * Time.deltaTime;

            this.transform.position = Vector3.MoveTowards(transform.position, openPos, step);
        }

        else
        {
            // The step size is equal to speed times frame time.
            var step = speed * Time.deltaTime;
            this.transform.position = Vector3.MoveTowards(transform.position, closePos, step);
        }
    }
}
