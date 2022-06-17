using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending_Ctrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("BackMain", 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BackMain()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
    }
}
