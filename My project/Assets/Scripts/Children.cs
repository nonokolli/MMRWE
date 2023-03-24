using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Children : MonoBehaviour
{
    public Move script;
   // public GameObject child;
    public GameObject child1;
    public GameObject child2;
    public GameObject child3;
    public GameObject child4;
    public Rigidbody cd1;
    // public bool isOnGround = true;

    //  int ColorState = 0;

    // Start is called before the first frame update
    void Start()
    {
        int sp = script.serialRead;
       // child.GetComponent<Renderer>().material.color = Color.white;
        child1.GetComponent<Renderer>().material.color = Color.white;
        child2.GetComponent<Renderer>().material.color = Color.white;
        child3.GetComponent<Renderer>().material.color = Color.white;
        child4.GetComponent<Renderer>().material.color = Color.white;
        cd1 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (script.serialRead == 1 )
        {
           // child.GetComponent<Renderer>().material.color = Color.red;
            child1.GetComponent<Renderer>().material.color = Color.red;
            child2.GetComponent<Renderer>().material.color = Color.red;
            child3.GetComponent<Renderer>().material.color = Color.red;
            child4.GetComponent<Renderer>().material.color = Color.red;
            
        }
        else if (script.serialRead == 2)
        {
            //child.GetComponent<Renderer>().material.color = Color.white;
            child1.GetComponent<Renderer>().material.color = Color.white;
            child2.GetComponent<Renderer>().material.color = Color.white;
            child3.GetComponent<Renderer>().material.color = Color.white;
            child4.GetComponent<Renderer>().material.color = Color.white;
            //cd1.AddForce(new Vector3(0, 4, 0), ForceMode.Impulse);
            transform.Translate(Vector3.left * Time.deltaTime * 10);
            //isOnGround = false;

        }
    }
    // private void OnCollisionEnter(Collision collision)
    //  {
    //      if (collision.gameObject.name == "Plane")
    //     {
    //         isOnGround = true;
    //    }
    // }  
}
