using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public GameObject button;

    public void PressedDown()
    {
        button.transform.localPosition = new Vector3(0, -0.07f, 0);
    }

    public void PressedUp()
    {
        button.transform.localPosition = new Vector3(0, 0, 0);
    }


    //find a way to get anim.Play("Base Layer.paperPrint"); in there, to make the thing print.
}
