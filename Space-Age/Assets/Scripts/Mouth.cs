using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouth : MonoBehaviour
{
    public int FoodEaten;
    [SerializeField] AudioSource NomNom;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Food")
        {
            FoodEaten++;
            NomNom.Play();
        }
    }
}
