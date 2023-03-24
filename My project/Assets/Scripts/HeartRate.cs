using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class HeartRate : MonoBehaviour
{
    // change your serial port
    SerialPort sp = new SerialPort("COM6", 9600);
    // Start is called before the first frame update
    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1; // In my case, 100 was a good amount to allow quite smooth transition. 
    }

    // Update is called once per frame
    void Update()
    {
        if (sp.IsOpen)
        {
            try
            {
                // When left button is pushed
                if (sp.ReadByte() == 1)
                {
                    //print(sp.ReadByte());
                    // transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
                    transform.Translate(Vector3.left * Time.deltaTime * 5);
                }
                
                
            }
            catch (System.Exception)
            {

            }

        }
    }
}
