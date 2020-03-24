using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BookButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public BookManager _bookManager;
    public Selection _selection;

    public Button bookButton;


    void Start()
    {
        _bookManager = GameObject.Find("BookManager").GetComponent<BookManager>();
        _selection = GameObject.Find("SelectionManager").GetComponent<Selection>();
        bookButton = gameObject.GetComponent<Button>();
        bookButton.onClick.AddListener(_bookManager.OpenCloseBook);
    }




    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse over Book");
        _selection.mouseOverBook = true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse exit Book");
        _selection.mouseOverBook = false;
    }
}
