using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdibleThing : MonoBehaviour
{
    public int bites;
    [SerializeField] Material bite1;
    [SerializeField] Material bite2;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mouth")
        {
            bites++;
        }
    }

    void Update()
    {
        if (bites == 1)
        {
            Material material = bite1; //Doesn't Work
        }

        if (bites == 2)
        {
            Material material = bite2; //Doesn't work
        }

        if (bites >= 3)
        {
            gameObject.SetActive(false);
        }
    }
}
