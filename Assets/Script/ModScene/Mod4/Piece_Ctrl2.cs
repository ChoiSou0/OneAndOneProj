using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;

public class Piece_Ctrl2 : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] private List<Image> Pic = new List<Image>();
    [SerializeField] private List<GameObject> Peace = new List<GameObject>();
    [SerializeField] private Sprite fin;
    private Mod4_Mgr mod4_Mgr;
    [SerializeField] bool isSelect;
    RectTransform rect;
    private RectTransform canvas;

    // Start is called before the first frame update
    void Start()
    {
        mod4_Mgr = GameObject.Find("Mod4UI_Mgr").GetComponent<Mod4_Mgr>();
        rect = GetComponent<RectTransform>();
        canvas = GameObject.Find("Canvas").GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
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
            gameObject.SetActive(false);
            switch (mod4_Mgr.stage)
            {
                case 1:
                    Pic[0].color = new Color(0.5f, 0, 1, 1);
                    break;

                case 2:
                    Pic[1].color = new Color(0.5f, 0, 1, 1);
                    break;

                case 3:
                    Pic[2].color = new Color(0.5f, 0, 1, 1);
                    break;
            }
            mod4_Mgr.Clear_Cnt++;
        }
        else
        {
            transform.localPosition = new Vector3(700, 0, 0);
            transform.localScale = new Vector3(2, 2, 2);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Puzzle2"))
            isSelect = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Puzzle2"))
            isSelect = false;
    }
}
