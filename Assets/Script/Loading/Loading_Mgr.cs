using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Loading_Mgr : MonoBehaviour
{
    [SerializeField] private Image Title_Img;
    bool s = true;
    // Start is called before the first frame update
    void Start()
    {
        Title_Img.transform.DOLocalMove(new Vector3(0, 0, 0), 1f).SetEase(Ease.Linear).SetEase(Ease.OutBounce);
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
