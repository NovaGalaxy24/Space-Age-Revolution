using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class tileCheckGo : MonoBehaviour
{
    public tileCounter tCounter;
    public string correctTile;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == correctTile)
        {
            Debug.Log("WOOOO");
            tCounter.AddTCount();
        }
       
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == correctTile)
        {
            Debug.Log("NOOOO");
            tCounter.LoseTCount();
        }
           
    }
}
