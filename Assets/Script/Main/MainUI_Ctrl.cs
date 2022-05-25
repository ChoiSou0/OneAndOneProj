using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI_Ctrl : MonoBehaviour
{
    [SerializeField] GameObject Select_Pnl;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 버튼 클릭
    #region
    // 옵션 버튼 클릭
    public void OnClickOption()
    {

    }

    // 주제 선택 버튼
    #region
    public void OnClickAni()
    {
        Select_Pnl.SetActive(true);
    }

    public void OnClickFruit()
    {
        Select_Pnl.SetActive(true);
    }

    public void OnClickVege()
    {
        Select_Pnl.SetActive(true);
    }

    public void OnClickVehicle()
    {
        Select_Pnl.SetActive(true);
    }
    #endregion

    // 모드 선택 버튼


    public void OnClickCancel()
    {
        Select_Pnl.SetActive(false);
    }

    #endregion

}
