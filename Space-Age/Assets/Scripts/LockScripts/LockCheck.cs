using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCheck : MonoBehaviour
{
    public bool smileLock;
    public bool mountLock;
    public bool equalLock;
    public bool arrowLock;
    private Animator anim;
    private AudioSource audio;
    public bool doorGo;
    void Start()
    {
        mountLock = false;
        equalLock = false;
        arrowLock = false;
        smileLock = false;
        anim = gameObject.GetComponent<Animator>();
        audio = gameObject.GetComponent<AudioSource>();
        doorGo = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (smileLock && mountLock && equalLock && arrowLock && doorGo)
        {
            Debug.Log("UNLOCK SUCCESS");
            anim.Play("Base Layer.doorOpen");
            doorGo = false;
            audio.Play(0);
        }
    }
}
