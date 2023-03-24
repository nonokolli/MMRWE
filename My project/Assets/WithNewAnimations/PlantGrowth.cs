using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
maxsize determines the max. scale
growFactor determine how fast it will scale, you could implement another float for breat$$anonymous$$ng out faster if you want to
waitTime will make the lung wait between breat$$anonymous$$ng in and breat$$anonymous$$ng out.*/

public class PlantGrowth : MonoBehaviour
{
    private PedalScale script;
    public float maxSize;
    private float timer = 0.0f;
    private int seconds;
    public int totalTime;
    public List<float> numbeats = new List<float>();
    [SerializeField]int calculationnum = 0;
    public float currentbeat;
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.FindObjectOfType<PedalScale>();
        calculationnum = 0;
        StartCoroutine(Scale(numbeats[0]));
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
        if (seconds >= totalTime)
        {
            calculationnum = 0;
            seconds = 0;
            timer = 0;
            if (script.serialRead == 1)
            {
                StopAllCoroutines();
                StartCoroutine(Scale(numbeats[0]));

            }
            else if (script.serialRead == 2)
            {
                StopAllCoroutines();
                StartCoroutine(Scale(numbeats[1]));
            }
           /* else
            {
                StopAllCoroutines();
                transform.localScale = new Vector3(1, 1, 1);
            }*/
          
        }
    }

    IEnumerator Scale(float growFactor)
    {
        float timer = 0;
        currentbeat = growFactor;
       while (calculationnum < 1 ) // t$$anonymous$$s could also be a condition indicating "alive or dead"
         {
            // we scale all axis, so they will have the same value, 
            // so we can work with a float instead of comparing vectors
            while(maxSize > transform.localScale.x)
             {
                timer += Time.deltaTime;
                transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime * growFactor;
                yield return null;
            }
            // reset the timer

            yield return null;

            timer = 0;
           while(1 < transform.localScale.x)
             {
                timer += Time.deltaTime;
                transform.localScale -= new Vector3(1, 1, 1) * Time.deltaTime * growFactor;
                yield return null;
            }

            timer = 0;
            yield return null;
            calculationnum -= 1;
        }
    }
}
