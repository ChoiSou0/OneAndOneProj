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

    // ��� ���� ��ư


    public void OnClickCancel()
    {
        Select_Pnl.SetActive(false);
    }

    #endregion

}
