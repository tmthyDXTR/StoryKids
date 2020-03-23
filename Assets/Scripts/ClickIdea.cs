using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickIdea : MonoBehaviour
{
    public bool isDragged = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (isDragged)
        {
            this.transform.parent.position = Input.mousePosition;
        }
    }

    public void ResetRotation()
    {
        if (!isDragged)
        {
            this.transform.Rotate(0, 0, 60);
            Debug.Log("Reset Rotation");
        }        
    }

    public void StartDrag()
    {
        Debug.Log("Drag");
        isDragged = true;
    }

    public void EndDrag()
    {
        Debug.Log("End Drag");
        isDragged = false;
    }
}
