using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCheck : MonoBehaviour
{
    public List<Image> white_key;

    public void Check()
    {
        white_key[0].color = Color.red;
        white_key[2].color = Color.red;
        white_key[4].color = Color.red;
    }

    public void Test()
    {
        Debug.Log("test");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
