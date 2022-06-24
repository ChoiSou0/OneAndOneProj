using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending_Ctrl : MonoBehaviour
{
    DataSave_Mgr data;
    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.Find("DataSave").GetComponent<DataSave_Mgr>();
        Invoke("BackMain", 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BackMain()
    {
        for (int i = 0; i < 3; i++)
            data.SelectType[i] = false;

        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
    }
}
