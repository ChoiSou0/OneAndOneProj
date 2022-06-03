using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;

public class Puzzle2_Ctrl : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] private Image Pic;
    [SerializeField] private GameObject Peace;
    [SerializeField] private Sprite fin;
    private Mod1_Mgr mod1_Mgr;
    private bool isSelect;
    public bool Compelete;
    // Start is called before the first frame update
    void Start()
    {
        mod1_Mgr = GameObject.Find("Mod1UI_Mgr").GetComponent<Mod1_Mgr>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.localScale = new Vector3(5, 5, 5);
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (isSelect)
        {

        }
        else
        {
            
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pzl2_Select"))
            isSelect = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Pzl2_Select"))
            isSelect= false;
    }


}
