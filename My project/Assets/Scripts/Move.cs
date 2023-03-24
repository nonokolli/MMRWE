using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Move : MonoBehaviour
{

	SerialPort sp = new SerialPort("COM3", 115200); // set port of your arduino connected to computer

	public float speed = 8f;
	public Rigidbody rb;
	public bool isOnGround = true;
	public int serialRead;
	public AudioSource audio;
	public AudioClip bell;
	//public AudioSource2 source2;
	//public AudioClip bird;

	void Start()
	{
		sp.Open();
		sp.ReadTimeout = 1;

		rb = GetComponent<Rigidbody>();
	}

	void Update()
	{
		if (sp.IsOpen)
		{
			serialRead = sp.ReadByte();

			try
			{
				Debug.Log(serialRead);

				if (serialRead == 1 && isOnGround)
				{
					
					rb.AddForce(new Vector3(0, 3f, 0), ForceMode.Impulse);
					isOnGround = false;
					//transform.Translate(Vector3.left * Time.deltaTime * 10);
				}
				if (serialRead == 2)
				{
					//transform.Translate(Vector3.right * Time.deltaTime * 10);
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

	private void OnCollisionEnter(Collision collision)
	{ 
		if (collision.gameObject.name == "Plane")
        {
			isOnGround = true;
        }
	}
}

