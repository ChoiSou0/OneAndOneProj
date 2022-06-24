using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;

public class Piece3_Ctrl : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] private Image Pic;
    [SerializeField] private GameObject Peace;
    [SerializeField] private Sprite fin;
    private Mod2_Mgr mod2_Mgr;
    [SerializeField] bool isSelect;
    private RectTransform rect;
    private RectTransform canvas;

    // Start is called before the first frame update
    void Start()
    {
        mod2_Mgr = GameObject.Find("Mod2UI_Mgr").GetComponent<Mod2_Mgr>();
        rect = GetComponent<RectTransform>();
        canvas = GameObject.Find("Canvas").GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.localScale = new Vector3(5, 5, 5);
        transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData evenData)
    {
        Vector2 viewportPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        Vector2 worldObjPos = new Vector2(
            (viewportPos.x * canvas.sizeDelta.x) - (canvas.sizeDelta.x * 0.5f),
            (viewportPos.y * canvas.sizeDelta.y) - (canvas.sizeDelta.y * 0.5f));
        this.rect.anchoredPosition = worldObjPos;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (isSelect && mod2_Mgr.Plz_Chs == 3)
        {
            mod2_Mgr.stage++;
        }
        else
        {
            transform.localPosition = new Vector3(500, -410, 0);
            transform.localScale = new Vector3(2, 2, 2);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Puzzle"))
            isSelect = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Puzzle"))
            isSelect = false;
    }
}
