using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public bool isDragged = false;

    public Selection _selection;

    public RecycleButton _recycle;
    public BookManager _bookManager;
    void Start()
    {
        _selection = GameObject.Find("SelectionManager").GetComponent<Selection>();
        _recycle = GameObject.Find("Recycle_Button").GetComponent<RecycleButton>();
        _bookManager = GameObject.Find("BookManager").GetComponent<BookManager>();
    }

    void Update()
    {
        if(isDragged)
        {
            this.transform.parent.position = Input.mousePosition;
        }
    }

    public void RotateIdea()
    {
        if (!isDragged && this.transform.parent.parent.name != "Content")
        {
            this.transform.Rotate(0, 0, 60);
            Debug.Log("Reset Rotation");
        }        
    }

    public void ResetRotation()
    {
        Debug.Log("Rotation Reset");

        transform.parent.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }

    public void OnBeginDrag (PointerEventData eventData)
    {
        Debug.Log("Drag");
        isDragged = true;
        _selection.selectedObj = this.transform.parent.gameObject;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //this.transform.parent.position = Input.mousePosition;        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        isDragged = false;


        if (_selection.mouseOverRecycle)
        {
            _recycle.RecyleIdea(this.transform.parent.gameObject);
        }

        if (_selection.mouseOverBook)
        {
            ResetRotation();
            _bookManager.AddIdeaToBook(this.transform.parent.gameObject);
        }

        _selection.selectedObj = null;
    }
}
