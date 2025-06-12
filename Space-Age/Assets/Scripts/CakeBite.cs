using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeBite : MonoBehaviour
{
    public GameObject Cake;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mouth")
        {
           Cake.SetActive (false);

        }
    }
}
