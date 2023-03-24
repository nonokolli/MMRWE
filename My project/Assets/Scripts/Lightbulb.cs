using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightbulb : MonoBehaviour
{
    private PedalScale script;
    public AudioSource audio;
    public AudioClip bell;
    public MeshRenderer BlubMaterial;
    public Light BlubLigther;
    private float timer = 0.0f;
    private int seconds;
    public int totalTime;
    public List<Color> ColorList = new List<Color>();
    void Start()
    {
        script = GameObject.FindObjectOfType<PedalScale>();
        setLighting(1);


    }

    // Update is called once per frame
    void Update()
    {
       
        timer += Time.deltaTime;       
        seconds = (int)(timer % 60);
        if (seconds >= totalTime) {
            seconds = 0;
            timer = 0;

            if (script.serialRead == 7)
            {
                setLighting(0);
               
            }
            else if (script.serialRead == 6)
            {
                setLighting(1);
               
            }
            else if (script.serialRead == 5)
            {
                setLighting(2);
                
            }
            if (script.serialRead == 8)
            {
                BlubLigther.enabled = false;
                BlubMaterial.materials[0].SetColor("_EmissionColor", Color.white);
                BlubLigther.color = Color.white;
                audio.PlayOneShot(bell);
      
            }
           /* else
            {
                BlubLigther.enabled = false;
                BlubMaterial.materials[0].SetColor("_EmissionColor", Color.white);
                BlubLigther.color = Color.white;
            }*/
           
           
        }

    }


    void setLighting(int indeer)
    {
        BlubLigther.enabled = true;   
        BlubMaterial.materials[0].SetColor("_EmissionColor", ColorList[indeer]);
        BlubLigther.color = ColorList[indeer];
    }
}
