using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Mod4_Mgr : MonoBehaviour
{
    public List<GameObject> Puzzle1 = new List<GameObject>();
    public List<GameObject> Puzzle2 = new List<GameObject>();
    public List<GameObject> Puzzle3 = new List<GameObject>();

    public List<Image> Img = new List<Image>();
    public List<Image> SelPiece = new List<Image>();
    public List<Image> SetPiece = new List<Image>();

    public List<Sprite> ImgSprite = new List<Sprite>();
    public List<Sprite> SelPieceSprite = new List<Sprite>();
    public List<Sprite> SetPieceSprite = new List<Sprite>();

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
        switch (stage)
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
            case 4:
                UnityEngine.SceneManagement.SceneManager.LoadScene("EndingScene");
                break;
        }

        if (Clear_Cnt == 3)
        {
            Clear_Cnt = 0;
            stage++;
        }
    }

    public void OnClickBack()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
    }

    public void Stage1()
    {
        if (start[0] == false)
        {
            start[0] = true;

            Puzzle1[0].SetActive(true);
            Puzzle1[1].SetActive(true);
            Puzzle1[2].SetActive(true);

            Puzzle3[0].SetActive(true);
            Puzzle3[1].SetActive(true);
            Puzzle3[2].SetActive(true);
            Img[0].color = new Color(1, 1, 1, 0.5f);
            Img[1].color = new Color(1, 1, 1, 0.5f);
            Img[2].color = new Color(1, 1, 1, 0.5f);

            SetSetting();
        }
    }

    public void Stage2()
    {
        if (start[1] == false)
        {
            start[1] = true;

            Puzzle1[0].SetActive(true);
            Puzzle1[1].SetActive(true);
            Puzzle1[2].SetActive(true);

            Puzzle3[3].SetActive(true);
            Puzzle3[4].SetActive(true);
            Puzzle3[5].SetActive(true);
            Img[3].color = new Color(1, 1, 1, 0.5f);
            Img[4].color = new Color(1, 1, 1, 0.5f);
            Img[5].color = new Color(1, 1, 1, 0.5f);

            SetSetting();
        }
    }

    public void Stage3()
    {
        if (start[2] == false)
        {
            start[2] = true;

            Puzzle1[0].SetActive(true);
            Puzzle1[1].SetActive(true);
            Puzzle1[2].SetActive(true);

            Puzzle3[6].SetActive(true);
            Puzzle3[7].SetActive(true);
            Puzzle3[8].SetActive(true);
            Img[6].color = new Color(1, 1, 1, 0.5f);
            Img[7].color = new Color(1, 1, 1, 0.5f);
            Img[8].color = new Color(1, 1, 1, 0.5f);

            SetSetting();
        }
    }

    private void SetSetting()
    {
        Puzzle1[0].transform.localPosition = new Vector3(1200, 300, 0);
        Puzzle1[1].transform.localPosition = new Vector3(1700, 0, 0);
        Puzzle1[2].transform.localPosition = new Vector3(2200, -300, 0);

         Puzzle1[0].transform.DOLocalMove(new Vector3(700, 300, 0), 1f);
         Puzzle1[1].transform.DOLocalMove(new Vector3(700, 0, 0), 1f);
         Puzzle1[2].transform.DOLocalMove(new Vector3(700, -300, 0), 1f);
    }                                            
}
