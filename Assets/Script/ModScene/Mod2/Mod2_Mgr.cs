using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Mod2_Mgr : MonoBehaviour
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

    public int Plz_Chs;
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
                Invoke("Endind", 3f);
                break;
        }
    }

    private void Ending()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("EndingScene");
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

    public void SetSetting()
    {
        for (int i = 0; i < 3; i++)
            Puzzle1[i].transform.localScale = new Vector3(2, 2, 2);

        Img[0].transform.localPosition = new Vector3(1000, -410, 0);
        Img[1].transform.localPosition = new Vector3(1500, -410, 0);
        Img[2].transform.localPosition = new Vector3(2000, -410, 0);

        Img[0].transform.DOLocalMove(new Vector3(-500, -410, 0), 1f);
        Img[1].transform.DOLocalMove(new Vector3(0, -410, 0), 1f);
        Img[2].transform.DOLocalMove(new Vector3(500, -410, 0), 1f);

        Plz_Chs = Random.Range(1, 4);
    }

    public void OnClickBack()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
    }
}
