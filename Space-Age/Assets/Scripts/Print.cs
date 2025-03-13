using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Print : MonoBehaviour
{
    public bool camPos;
    public GameObject paper;
    Animator animPrint;
    private AudioSource audio;

    private void Start()
    {
        camPos = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Camera Tracker")
        {
            animPrint = GetComponentInChildren<Animator>();
            audio = gameObject.GetComponent<AudioSource>();
            camPos = true;
            Debug.Log("Cam Correct!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Camera Tracker")
        {
            camPos = false;
            Debug.Log("Cam Lost!");
        }
    }
    
    public void Printer()
    {
        if (camPos)
            {
            Debug.Log("Camera Animation Triggered!");
            animPrint.Play("photoPrint");
            audio.Play(0);
        }
    }
}
