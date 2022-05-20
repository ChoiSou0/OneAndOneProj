using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Test : MonoBehaviour
{
    [SerializeField] GameObject gameObject;
    Vector2 mousePosition;

    bool Select;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDrag()
    {
        Debug.Log("드래그중");
    }

    //public void OnEnd

    //public void Drag()
    //{
    //    transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    //}

    //public void Drop()
    //{
    //    if (Select)
    //    {

    //    }
    //    else
    //    {
    //        transform.position = new Vector2(-1, -4);
    //    }
    //}

}
