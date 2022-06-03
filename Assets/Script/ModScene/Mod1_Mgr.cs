using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class Mod1_Mgr : MonoBehaviour
{
    public List<GameObject> Puzzle1 = new List<GameObject>();
    public List<GameObject> Puzzle2 = new List<GameObject>();
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
                Stage2(true);
                break;

            case 3:
                Stage3(true);
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
            Puzzle1[0].transform.DOMove(new Vector3(960, 115, 0), 1f).SetEase(Ease.Linear);
            Puzzle1[1].transform.DOMove(new Vector3(460, 115, 0), 1f).SetEase(Ease.Linear);
            Puzzle1[2].transform.DOMove(new Vector3(1460, 115, 0), 1f).SetEase(Ease.Linear);

            Puzzle2[0].transform.DOMove(new Vector3(460, 640, 0), 1f).SetEase(Ease.Linear);
            Puzzle2[1].transform.DOMove(new Vector3(960, 640, 0), 1f).SetEase(Ease.Linear);
            Puzzle2[2].transform.DOMove(new Vector3(1460, 640, 0), 1f).SetEase(Ease.Linear);
        }
    }

    public void Stage2(bool start)
    {
        if (start == true)
        {

        }
    }

    public void Stage3(bool start)
    {
        if (start == true)
        {

        }
    }


}
