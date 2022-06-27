using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;

public class Piece1 : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] private Image Pic;
    [SerializeField] private GameObject Peace;
    [SerializeField] private Sprite fin;
    private Mod3_Mgr mod3_Mgr;
    [SerializeField] bool isSelect;
    RectTransform rect;
    private RectTransform canvas;

    // Start is called before the first frame update
    void Start()
    {
        mod3_Mgr = GameObject.Find("Mod3UI_Mgr").GetComponent<Mod3_Mgr>();
        rect = GetComponent<RectTransform>();
        canvas = GameObject.Find("Canvas").GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.localScale = new Vector3(3, 3, 3);
        transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData evenData)
    {
        //rectTransform.anchoredPosition = Input.mousePosition;
        Vector2 viewportPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        Vector2 worldObjPos = new Vector2(
            (viewportPos.x * canvas.sizeDelta.x) - (canvas.sizeDelta.x * 0.5f),
            (viewportPos.y * canvas.sizeDelta.y) - (canvas.sizeDelta.y * 0.5f));
        this.rect.anchoredPosition = worldObjPos;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (isSelect)
        {
            transform.localPosition = new Vector3(150, 300, 0);
            gameObject.SetActive(false);
            Peace.SetActive(true);
            Pic.color = new Color(0, 0, 1, 1);
            mod3_Mgr.Clear_Cnt++;
        }
        else
        {
            transform.localPosition = new Vector3(-750, -410, 0);
            transform.localScale = new Vector3(2, 2, 2);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pzl2"))
            isSelect = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Pzl2"))
            isSelect = false;
    }
}
