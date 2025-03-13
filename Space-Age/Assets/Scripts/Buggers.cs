using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Buggers : MonoBehaviour
{
    private AudioSource audio;
    private Animator anim;

    private void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        anim = gameObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
            audio.Play(0);
            anim.Play("Buggers");
    }
    private void OnTriggerExit(Collider other)
    {
        anim.Play("Idle");
    }
}
