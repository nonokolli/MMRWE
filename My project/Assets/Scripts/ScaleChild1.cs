using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChild1 : MonoBehaviour
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
            transform.localScale = new Vector3(0.8f, 0.7f, 0.7f);
            GameObject.Find("Child1").GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (script.serialRead == 2)
        {
            transform.localScale = new Vector3(0.3f, 0.1f, 0.3f);
            GameObject.Find("Child1").GetComponent<Renderer>().material.color = Color.green;
        }
    }
}

