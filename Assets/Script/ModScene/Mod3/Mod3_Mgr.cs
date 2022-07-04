using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Mod3_Mgr : MonoBehaviour
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
                Invoke("Stage2", 3f);
                break;

            case 3:
                Invoke("Stage3", 3f);
                break;
            case 4:
                Invoke("Ending",  3f);
                break;
        }

        if (Clear_Cnt == 4)
        {
            Clear_Cnt = 0;
            stage++;
        }

    }

    private void Ending()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("EndingScene");
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
        for (int i = 0; i < 4; i++)
        {
            Puzzle1[i].SetActive(true);
            Img[i].color = new Color(1, 1, 1, 0.5f);
            Puzzle1[i].transform.localScale = new Vector3(2, 2, 2);
        }

        Puzzle1[0].transform.localPosition = new Vector3(1250, -410, 0);
        Puzzle1[1].transform.localPosition = new Vector3(1750, -410, 0);
        Puzzle1[2].transform.localPosition = new Vector3(2250, -410, 0);
        Puzzle1[3].transform.localPosition = new Vector3(2750, -410, 0);

        Puzzle1[0].transform.DOLocalMove(new Vector3(-750, -410, 0), 1f).SetEase(Ease.Linear);
        Puzzle1[1].transform.DOLocalMove(new Vector3(-250, -410, 0), 1f).SetEase(Ease.Linear);
        Puzzle1[2].transform.DOLocalMove(new Vector3(250, -410, 0), 1f).SetEase(Ease.Linear);
        Puzzle1[3].transform.DOLocalMove(new Vector3(750, -410, 0), 1f).SetEase(Ease.Linear);
    }

}
