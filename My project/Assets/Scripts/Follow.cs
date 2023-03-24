using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    float speed = 10.0f;
    Vector3 sDirection;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sDirection = (target.position - transform.position).normalized;
        transform.Translate(sDirection * Time.deltaTime * speed);
    }
}
