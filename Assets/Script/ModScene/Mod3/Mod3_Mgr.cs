using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mod3_Mgr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickBack()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
    }
}
