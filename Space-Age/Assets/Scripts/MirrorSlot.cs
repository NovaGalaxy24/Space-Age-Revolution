using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorSlot : MonoBehaviour
{
    public int mirror;
    Animator animMirror;
    

    void Start()
    {
        mirror = 0;
        animMirror = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mirror == 6)
        {
            Debug.Log("Mirror Trial Complete!");
            animMirror.Play("Base Layer.EqualReveal");
            
        }
    }

    public void AddMirror()
    {
        mirror = mirror + 1;
    }

    public void RemoveMirror()
    {
        mirror = mirror - 1;
    }

}

