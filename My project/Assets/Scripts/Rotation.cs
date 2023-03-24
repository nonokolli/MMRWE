using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private PedalScale script;
    private float speed = 1000;
    private float timer = 0.0f;
    private int seconds;
    public int totalTime;
    public List<int> speeds = new List<int>();
    void Start()
    {
        script = GameObject.FindObjectOfType<PedalScale>();
        speed = speeds[0];
    }

    // fix time - perform 30 ssecond of rotation then listen to the next signal - 3 or 4

    void Update()
    {

        transform.eulerAngles += new Vector3(0,0, speed * Time.deltaTime);
        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
        if (seconds > totalTime)
        {
            seconds = 0;
            timer = 0;

            if (script.serialRead == 3)
            {
                speed = speeds[1];
            }
            else if (script.serialRead == 4)
            {
                speed = speeds[0];
            }
            //else
            //{
            //    speed = 0;
           // }

           
        }
    }
}
