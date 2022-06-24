using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSave_Mgr : MonoBehaviour
{
    public GameObject Click_Particle;
    public bool[] SelectType = new bool[4];

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        MouseOnClick();
        //Debug.Assert(SelectType[0] == true);
        //Debug.Assert(SelectType[1] == true);
        //Debug.Assert(SelectType[2] == true);
        //Debug.Assert(SelectType[3] == true);
    }

    private void MouseOnClick()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 Pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var Clone = Instantiate(Click_Particle, Pos, transform.rotation);
            DestroyObject(Clone, 2f);
        }
    }
}
