using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileCounter : MonoBehaviour
{
    public int TCount;
    public bool notNow;
    private Animator fallDown;
    private AudioSource audio;

    void Start()
    {
        TCount = 0;
        notNow = true;
        fallDown = gameObject.GetComponent<Animator>();
        audio = gameObject.GetComponent<AudioSource>();
    }

    public void AddTCount()
    {
        TCount = TCount + 1; 
    }

    public void LoseTCount()
    { 
        TCount = TCount - 1; 
    }

    void Update()
    {
        if (notNow && (TCount == 24))
        {
            Debug.Log("CorrectSlider!");
            fallDown.Play("Base Layer.ItAllFallsDown");
            audio.Play(0);
            notNow = false;
        }
    }
}
