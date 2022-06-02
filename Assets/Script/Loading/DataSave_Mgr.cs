using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSave_Mgr : MonoBehaviour
{
    public bool[] SelectMod = new bool[6];

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
