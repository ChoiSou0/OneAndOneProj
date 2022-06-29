using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Test : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public GameObject image;
    public bool isSelect;
    Vector2 mousePosition;

    bool Select;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isSelect);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        image.transform.localScale = new Vector3(2, 4, 2);
        //throw new System.NotImplementedException();
    }

    public void OnDrag(PointerEventData eventData)
    {
        image.transform.position = Input.mousePosition;
        //throw new System.NotImplementedException();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (isSelect)
        {
            image.transform.localPosition = new Vector3(-100, 0, 0);
        }
        else 
        {
            image.transform.localPosition = new Vector3(0, -1250, 0);
            image.transform.localScale = new Vector3(1, 2, 1);
        }
        // throw new System.NotImplementedException();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Hom"))
            isSelect = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Hom"))
            isSelect = false;
    }

}
