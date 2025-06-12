using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

public class TaskTracker : MonoBehaviour
{
    // Task Tracker Setup WIP
    // Task TODOs: 
    // Exercise Task - Complete!
    // Plant Task - Model's required
    // Food Task - Models required
    // Entertainment Task - Complete!
    // Task Tracker - Complete!


    public int taskTracker;

    public UnityEvent CheckedOff;

    // Exersise Task
    public bool exerciseTask;
    public int checkpointCounter;
    [SerializeField] GameObject pingSourceAthletics;
    [SerializeField] GameObject athleticsExit;
    [SerializeField] GameObject athleticsGame;
    public UnityEvent outside;
    public UnityEvent inside;

    //Entertainment Task
    public bool entertainmentTask;
    public int entertaintime;
    public bool addingETime;

    public UnityEvent dialogueChange;

    
    void Start()
    {
        taskTracker = 0;
        checkpointCounter = 0;
        entertaintime = 0;
        entertainmentTask = true;
        addingETime = false;
        exerciseTask = false;
    }


    private void Update()
    {
        //excersise checkpoint code
        if (exerciseTask)
        {
            if (checkpointCounter == 10)
             {
                inside.Invoke();
                taskTracker ++;
                transform.position = athleticsExit.transform.position;
                exerciseTask = false;
                
            }
        }

        if (entertainmentTask)
        {
            if (entertaintime >= 4000)
            {
                CheckedOff.Invoke();
                taskTracker ++;
                entertainmentTask = false;
            }
            else if (addingETime)
            {
                entertaintime++;
            }
        }
          
      

        if (taskTracker == 4)
        {
            dialogueChange.Invoke();
            Debug.Log("ay it worked!");
            taskTracker++;
        }
             
    }

  

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
            outside.Invoke();
            exerciseTask = true;
            transform.position = athleticsGame.transform.position;
        }
    }

    public void IsEntertained()
    {
       if (addingETime)
        {
            addingETime = false;
        }
       else if (!addingETime)
        {
            addingETime = true;
        }
    }

}
