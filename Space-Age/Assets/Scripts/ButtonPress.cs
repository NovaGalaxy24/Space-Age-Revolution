using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public GameObject button;
    public bool switched;
    public GameObject other;
    public GameObject other2;
    
    

    public void PressedDown()
    {
        button.transform.localPosition = new Vector3(0, -0.003f, 0);
    }

    public void PressedUp()
    {
        button.transform.localPosition = new Vector3(0, 0, 0);
    }

    public void Switch()
    {
        if (switched)
        {
            other.SetActive(false);
            other2.SetActive(false);
            switched = false;
        }
        else if (!switched)
        {
            other.SetActive(true);
            other2.SetActive(true);
            switched = true;
        }
    }

}
