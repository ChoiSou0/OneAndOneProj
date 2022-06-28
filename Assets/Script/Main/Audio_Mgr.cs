using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio_Mgr : MonoBehaviour
{
    Scrollbar SoundBar;
    Toggle Mute_Tog;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        
        audio = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Mute_Tog = GameObject.Find("Mute_Tog").GetComponent<Toggle>();
        //SoundBar = GameObject.Find("BGM_Sbar").GetComponent<Scrollbar>();

        if (GameObject.Find("Mute_Tog"))
        {
            Mute_Tog = GameObject.Find("Mute_Tog").GetComponent<Toggle>();
            OnClickMute();
        }
        if (GameObject.Find("BGM_Sbar"))
        {
            SoundBar = GameObject.Find("BGM_Sbar").GetComponent<Scrollbar>();
            audio.volume = SoundBar.value;
        }

        
        
    }

    private void OnClickMute()
    {
        if (Mute_Tog.isOn)
            audio.mute = true;
        else
            audio.mute = false;
    }

}
