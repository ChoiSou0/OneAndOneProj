using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Loading_Mgr : MonoBehaviour
{
    bool s = true;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("GoMain", 5f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GoMain()
    {
        SceneManager.LoadScene("MainScene");
    }

}