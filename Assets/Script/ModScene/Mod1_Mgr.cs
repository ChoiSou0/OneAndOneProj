using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class Mod1_Mgr : MonoBehaviour
{
    public List<GameObject> Puzzle1 = new List<GameObject>();
    public List<GameObject> Puzzle2 = new List<GameObject>();
    public List<GameObject> Puzzle3 = new List<GameObject>();

    public List<Image> Img = new List<Image>();
    public List<Image> SelPiece = new List<Image>();
    public List<Image> SetPiece = new List<Image>();

    public List<Image> ImgSprite = new List<Image>();
    public List<Image> SelPieceSprite = new List<Image>();
    public List<Image> SetPieceSprite = new List<Image>();

    public int Clear_Cnt = 0;
    public int stage = 1;
    public bool[] start = new bool[3] { false, false, false };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(stage)
        {
            case 1:
                Stage1();
                break;

            case 2:
                Stage2();
                break;

            case 3:
                Stage3();
                break;
        }

        if (Clear_Cnt == 3)
        {
            Clear_Cnt = 0;
            stage++;
        }

    }

    public void Stage1()
    {
        if (start[0] == false)
        {
            start[0] = true;

            SetSetting();
        }
    }

    public void Stage2()
    {
        if (start[1] == false)
        {
            start[1] = true;

            SetSetting();
        }
    }

    public void Stage3()
    {
        if (start[2] == false)
        {
            start[2] = true;

            SetSetting();
        }
    }

    private void SetSetting()
    {
        Puzzle1[0].SetActive(true);
        Puzzle1[1].SetActive(true);
        Puzzle1[2].SetActive(true);

        Puzzle3[0].SetActive(true);
        Puzzle3[1].SetActive(true);
        Puzzle3[2].SetActive(true);

        Puzzle1[0].transform.localScale = new Vector3(2, 2, 2);
        Puzzle1[1].transform.localScale = new Vector3(2, 2, 2);
        Puzzle1[2].transform.localScale = new Vector3(2, 2, 2);

        Puzzle1[0].transform.localPosition = new Vector3(2000, -425, 0);
        Puzzle1[1].transform.localPosition = new Vector3(1500, -425, 0);
        Puzzle1[2].transform.localPosition = new Vector3(2500, -425, 0);

        Puzzle2[0].transform.localPosition = new Vector3(-1500, 100, 0);
        Puzzle2[1].transform.localPosition = new Vector3(0, 1000, 0);
        Puzzle2[2].transform.localPosition = new Vector3(1500, 100, 0);

        Puzzle1[0].transform.DOLocalMove(new Vector3(0, -425, 0), 1f).SetEase(Ease.Linear);
        Puzzle1[1].transform.DOLocalMove(new Vector3(-500, -425, 0), 1f).SetEase(Ease.Linear);
        Puzzle1[2].transform.DOLocalMove(new Vector3(500, -425, 0), 1f).SetEase(Ease.Linear);
        Puzzle2[0].transform.DOLocalMove(new Vector3(-500, 100, 0), 1f).SetEase(Ease.Linear);
        Puzzle2[1].transform.DOLocalMove(new Vector3(0, 100, 0), 1f).SetEase(Ease.Linear);
        Puzzle2[2].transform.DOLocalMove(new Vector3(500, 100, 0), 1f).SetEase(Ease.Linear);
    }
}
