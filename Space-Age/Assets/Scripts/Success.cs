using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Success : MonoBehaviour
{
    private AudioSource audio;

    private void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
            audio.Play(0);
            Debug.Log("Found Spot"); 
        
    }

}
