using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChild : MonoBehaviour
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
            transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            GameObject.Find("Child").GetComponent<Renderer>().material.color = Color.red;
        }
        else if (script.serialRead == 2)
        {
            transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            GameObject.Find("Child").GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
