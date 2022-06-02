using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Mod1UI_Ctrl : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public List<GameObject> Any = new List<GameObject>();
    public bool isSelect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (gameObject.name == "Frog1")
            Debug.Log("À¸");
    }

    public void OnDrag(PointerEventData eventData)
    {

    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }

}
