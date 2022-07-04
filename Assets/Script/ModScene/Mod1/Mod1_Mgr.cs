using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class Mod1_Mgr : MonoBehaviour
{
    private DataSave_Mgr data;

    public List<GameObject> Puzzle1 = new List<GameObject>();
    public List<GameObject> Puzzle2 = new List<GameObject>();
    public List<GameObject> Puzzle3 = new List<GameObject>();

    public List<Image> Name = new List<Image>();
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
        switch(stage)
        {
            case 1:
                Stage1();
                break;

            case 2:
                Invoke("Stage2", 3f);
                break;

            case 3:
                Invoke("Stage3", 3f);
                break;
            case 4:
                Invoke("Ending", 3f);
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

            for(int i = 0; i < 2; i++)
            {
                Img[i].sprite = ImgSprite[i];
                SelPiece[i].sprite = SelPieceSprite[i];
                SetPiece[i].sprite = SetPieceSprite[i];
            }

            SetSetting();
        }
    }

    public void Stage2()
    {
        if (start[1] == false)
        {
            start[1] = true;

            for (int i = 0; i < 3; i++)
            {
                Img[i].sprite = ImgSprite[i + 3];
                SelPiece[i].sprite = SelPieceSprite[i + 3];
                SetPiece[i].sprite = SetPieceSprite[i + 3];
            }

            SetSetting();
        }
    }

    public void Stage3()
    {
        if (start[2] == false)
        {
            start[2] = true;

            for (int i = 0; i < 3; i++)
            {
                Img[i].sprite = ImgSprite[i + 6];
                SelPiece[i].sprite = SelPieceSprite[i + 6];
                SetPiece[i].sprite = SetPieceSprite[i + 6];
            }

            SetSetting();
        }
    }

    public void Ending()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("EndingScene");
    }

    private void SetSetting()
    {
        for (int i = 0; i < 3; i++)
        {
            Puzzle1[i].SetActive(true);
            Img[i].color = new Color(1, 1, 1, 0.5f);
            Puzzle3[i].SetActive(true);
            Puzzle1[i].transform.localScale = new Vector3(2, 2, 2);
            Name[i].enabled = false;
        }

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

    public void OnClickBack()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
    }

}
