using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MainUI_Ctrl : MonoBehaviour
{
    [Header("판넬")]
    [SerializeField] GameObject Select_Pnl;
    [Space(10f)]

    [Header("버튼")]
    [SerializeField] Button Option_Btn;
    [SerializeField] Button Animal_Btn;
    [SerializeField] Button Fruit_Btn;
    [SerializeField] Button Vegetable_Btn;
    [SerializeField] Button Vehicle_Btn;
    [SerializeField] Button Cancel_Btn;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Btn_Ani();
    }

    void Btn_Ani()
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
        Select_Pnl.transform.DOScale(Vector3.one, 0.5f);
    }

    public void OnClickFruit()
    {
        Select_Pnl.transform.DOScale(Vector3.one, 0.5f);
    }

    public void OnClickVege()
    {
        Select_Pnl.transform.DOScale(Vector3.one, 0.5f);
    }

    public void OnClickVehicle()
    {
        Select_Pnl.transform.DOScale(Vector3.one, 0.5f);
    }
    #endregion

    // 모드 선택 버튼


    public void OnClickCancel()
    {
        Select_Pnl.transform.DOScale(Vector3.zero, 0.5f);
    }

    #endregion

}