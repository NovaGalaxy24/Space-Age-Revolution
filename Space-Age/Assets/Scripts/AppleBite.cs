using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleBite : MonoBehaviour
{
    public GameObject Apple;
    public GameObject Fresh;
    public GameObject Bite;

    public int bites;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mouth")
        {
            bites++; 
            if (bites == 2)
            {
                Apple.SetActive(false);
            }
            else
            {
                Fresh.SetActive(false);
                Bite.SetActive(true);
            }
          
           
        }
    }
}
