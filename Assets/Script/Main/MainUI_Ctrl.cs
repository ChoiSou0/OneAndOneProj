using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MainUI_Ctrl : MonoBehaviour
{
    [Header("�ǳ�")]
    [SerializeField] GameObject Select_Pnl;
    [Space(10f)]

    [Header("��ư")]
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

    // ��ư Ŭ��
    #region
    // �ɼ� ��ư Ŭ��
    public void OnClickOption()
    {

    }

    // ���� ���� ��ư
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

    // ��� ���� ��ư


    public void OnClickCancel()
    {
        Select_Pnl.transform.DOScale(Vector3.zero, 0.5f);
    }

    #endregion

}