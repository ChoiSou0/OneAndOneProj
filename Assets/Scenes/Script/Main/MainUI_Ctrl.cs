using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainUI_Ctrl : MonoBehaviour
{
    DataSave_Mgr data;
    AudioSource audio;

    [Header("�ǳ�")]
    [SerializeField] GameObject Select_Pnl;
    [SerializeField] GameObject Option_Pnl;
    [Space(10f)]

    [Header("��ư")]
    [SerializeField] Button Option_Btn;
    [SerializeField] Button Animal_Btn;
    [SerializeField] Button Fruit_Btn;
    [SerializeField] Button Vegetable_Btn;
    [SerializeField] Button Vehicle_Btn;
    [SerializeField] Button Cancel_Btn;

    Toggle Mute_Tog;
    Scrollbar SoundBar;

    private void Awake()
    {
        data = GameObject.Find("DataSave").GetComponent<DataSave_Mgr>();
        audio = GameObject.Find("Audio_Mgr").GetComponent<AudioSource>();
        Mute_Tog = GameObject.Find("Mute_Tog").GetComponent<Toggle>();
        SoundBar = GameObject.Find("BGM_Sbar").GetComponent<Scrollbar>();

        SoundBar.value = audio.volume;
        Mute_Tog.isOn = audio.mute;
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 4; i++)
            data.SelectType[i] = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ��ư Ŭ��
    #region
    //������ ��ư
    public void OnClickExit()
    {
        Application.Quit();
    }
    //ũ���� ��ư
    public void OnClickCredit()
    {

    }

    // �ɼ� ��ư Ŭ��
    public void OnClickOption()
    {
        Option_Pnl.transform.DOLocalMove(new Vector2(0, 0), 1f).SetEase(Ease.Linear).SetEase(Ease.OutBounce);
    }

    public void OnClickOptionCancel()
    {
        Option_Pnl.transform.DOLocalMove(new Vector2(0, 1000), 0.5f).SetEase(Ease.Linear);
    }

    // ���� ���� ��ư
    #region
    public void OnClickAni()
    {
        Select_Pnl.transform.DOScale(Vector3.one, 0.5f);
        data.SelectType[0] = true;
    }

    public void OnClickFruit()
    {
        Select_Pnl.transform.DOScale(Vector3.one, 0.5f);
        data.SelectType[1] = true;
    }

    public void OnClickVege()
    {
        Select_Pnl.transform.DOScale(Vector3.one, 0.5f);
        data.SelectType[2] = true;
    }

    public void OnClickVehicle()
    {
        Select_Pnl.transform.DOScale(Vector3.one, 0.5f);
        data.SelectType[3] = true;
    }
    #endregion

    // ��� ���� ��ư
    #region
    public void OnClickMod1()
    {
        SceneManager.LoadScene("Mod1Scene");
    }

    public void OnClickMod2()
    {
        SceneManager.LoadScene("Mod2Scene");
    }

    public void OnClickMod3()
    {
        SceneManager.LoadScene("Mod3Scene");
    }

    public void OnClickMod4()
    {
        SceneManager.LoadScene("Mod4Scene");
    }

    public void OnClickMod5()
    {
        SceneManager.LoadScene("Mod5Scene");
    }

    public void OnClickMod6()
    {
        SceneManager.LoadScene("Mod6Scene");
    }
    
    #endregion

    public void OnClickCancel()
    {
        Select_Pnl.transform.DOScale(Vector3.zero, 0.5f);
        data.SelectType[0] = false;
        data.SelectType[1] = false;
        data.SelectType[2] = false;
        data.SelectType[3] = false;
    }

    #endregion

}