using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class TaskTracker : MonoBehaviour
{
    // Task Tracker Setup WIP
    // Task TODOs: 
    // Exercise Task - Complete! (Altough make invisible walls to prevent escape)
    // Plant Task - Incomplete
    // Food Task - Incomplete
    // Entertainment Task - Incomplete
    // Task Tracker - Find A way to update dialouge state

    public int taskTracker;

    // Exersise Task
    public bool exerciseTask;
    public int checkpointCounter;


    
    void Start()
    {
        taskTracker = 0;
        checkpointCounter = 0;
        exerciseTask = false;
    }


    private void Update()
    {
        //excersise checkpoint code
        if (exerciseTask)
        {
            if (checkpointCounter == 10)
             {
                // SFX to indicate Finished Task
                taskTracker += 1;
                transform.position = athleticsExit.transform.position;
                exerciseTask = false;
                athleticsCp.gameObject.SetActive(false);
            }
        }

        if (taskTracker == 4)
        {
            //update Dialouge State to "d"
        }
             
    }

    [SerializeField] GameObject pingSourceAthletics;
    [SerializeField] GameObject athleticsExit;
    [SerializeField] GameObject athleticsGame;
    [SerializeField] GameObject athleticsCp;
    [SerializeField] GameObject athleticsExitCp;

    //bool hasTriggered;
    private void OnTriggerEnter(Collider other)
    {
        //if (hasTriggered) return;
        //hasTriggered = true;

        if (exerciseTask && (other.tag == "Checkpoint"))
        {

            Instantiate(pingSourceAthletics, transform.position, transform.rotation);
            Destroy(other.gameObject);
            checkpointCounter += 1;
            Debug.Log("Check Point Found, Total Numberr:" + checkpointCounter);
        }

        if ((checkpointCounter < 10) && (other.tag == "Athletics"))
        {
            exerciseTask = true;
            transform.position = athleticsGame.transform.position;
            athleticsCp.gameObject.SetActive(true);
        }
    }

    
  


}
