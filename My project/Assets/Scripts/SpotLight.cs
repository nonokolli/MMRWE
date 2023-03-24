using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLight : MonoBehaviour
{

    public Light light;
    public float r = 1;
    public float g = 1;
    public float b = 1;

    public float smooth = 100;
    void Start()
    {
        light.color = new Color(r, g, b);
    }
    void Update()
    {
        r -= Time.deltaTime / smooth;
        g -= Time.deltaTime / smooth;
        light.color = new Color(r, g, b);
        if (r <= 0) { r = 0; }
        if (g <= 0) { g = 0; }
    }
}