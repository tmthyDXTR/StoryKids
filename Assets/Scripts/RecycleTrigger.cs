using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleTrigger : MonoBehaviour
{
    public RecycleButton _recycle;
    void Start()
    {
        _recycle = GameObject.Find("Recycle_Button").GetComponent<RecycleButton>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
         _recycle.RecyleIdea(other.gameObject);
    }
}
