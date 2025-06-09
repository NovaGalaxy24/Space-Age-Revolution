using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mouth : MonoBehaviour
{
    public int foodEaten;
    public TaskTracker TaskTrack;
    [SerializeField] AudioSource NomNom;
    public bool Hungry;
    public UnityEvent Full;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Food")
        {
            foodEaten++;
            NomNom.Play();

        }
    }

     void Start()
    {
      Hungry = true;
    }

    void Update()
    {
        if (Hungry && (foodEaten == 8))
        {
            TaskTrack.taskTracker += 1;
            Hungry = false;
            Full.Invoke();
        }
    }
}

