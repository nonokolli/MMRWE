using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Move script;
    // Start is called before the first frame update
    void Start()
    {
        int sp = script.serialRead;

    }

    // Update is called once per frame
    void Update()
    {
        if (script.serialRead == 1)
        {
            GameObject.Find("mushroom").GetComponent<Renderer>().material.color = Color.black;
                //new Color(47, 97, 57);
        }
        else if (script.serialRead == 2)
        {
            GameObject.Find("mushroom").GetComponent<Renderer>().material.color = Color.white;
        }
    }

}