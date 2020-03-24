using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RecycleButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Idea I;
    public IdeaButton ideaBtn;
    public Selection _selection;

    public Transform wallBottom;
    public Vector3 wallBottomOrigPos;
    public BoxCollider2D recycleCollider;
    //// The object whose rotation we want to match.
    //public Transform target;
    //// The object we want to rotate.
    //public Transform objToRotate;
    //// The original object rotation we rotate
    //public Quaternion origRotation;
    //// Angular speed in degrees per sec.
    public float speed;

    public float waitTime = 2f;
    private float timer = 0f;
    void Start()
    {
        _selection = GameObject.Find("SelectionManager").GetComponent<Selection>();
        //objToRotate = GameObject.Find("Wall_Left").transform;
        //target = GameObject.Find("Wall_Left_Target").transform;
        //origRotation = objToRotate.rotation;
        wallBottom = GameObject.Find("Wall_Bottom").transform;
        wallBottomOrigPos = wallBottom.position;
        recycleCollider = GameObject.Find("Recycle_Trigger").GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0) && _selection.selectedObj == null && _selection.mouseOverRecycle)
        {
            Debug.Log("Recycling");

            //// The step size is equal to speed times frame time.
            //var step = speed * Time.deltaTime;
            //// Rotate our transform a step closer to the target's.
            //objToRotate.rotation = Quaternion.RotateTowards(objToRotate.rotation, target.rotation, step);

            //if (objToRotate.rotation == target.rotation)
            //{
            //    Debug.Log("Pit activated");

            //    wallBottom.position += new Vector3(0, -400, 0);
            //}

            timer += Time.deltaTime;

            if (timer > waitTime)
            {
                wallBottom.position += new Vector3(0, -50, 0);
                recycleCollider.enabled = true;
            }

        }
        else
        {
            //// The step size is equal to speed times frame time.
            //var step = speed * Time.deltaTime;
            //// Rotate our transform a step closer to the target's.
            //objToRotate.rotation = Quaternion.RotateTowards(objToRotate.rotation, origRotation, step * 2);
            wallBottom.position = wallBottomOrigPos;
            timer = 0;
            recycleCollider.enabled = false;
        }
    }

    public void RecyleIdea(GameObject idea)
    {


        if (idea.tag == "Mood")
        {
            I.Spawn("mood");
        }

        if (idea.tag == "Idea")
        {
            ideaBtn.UpdateIdeaButton();
        }

        Destroy(idea);
              
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse over Recycle");
        _selection.mouseOverRecycle = true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse exit Recycle");
        _selection.mouseOverRecycle = false;
    }
}
