using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class PedalScale : MonoBehaviour
{

	SerialPort sp = new SerialPort("COM3", 115200); // set port of your arduino connected to computer

	Vector3 scaleChange = new Vector3(0.5f, 0.5f, 0.5f);

	public int serialRead;
	public AudioSource audio;
	public AudioClip bell;
	private GameObject pedal;
	//public AudioSource2 source2;
	//public AudioClip bird;

	void Start()
	{
		sp.Open();
		sp.ReadTimeout = 1;

	}

	void Update()
	{
		if (sp.IsOpen)
		{

			try
			{
                serialRead = sp.ReadByte();
                Debug.Log(serialRead);

				if (serialRead == 1)
				{
					//pedal.transform.localScale = new Vector3(2f, 2f, 2f);

				}
				if (serialRead == 2)
				{
					//pedal.transform.localScale = new Vector3(1f, 1f, 1f);
				}
				if (serialRead == 3)
				{
					audio.PlayOneShot(bell);
					//relaxation sound;
				}
				if (serialRead == 4)
				{
					audio.Stop();
					//bird sound;
				}
			}
			catch (System.Exception)
			{
			}
		}
	}
}
