using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterThePlants : MonoBehaviour
{


    [SerializeField] GameObject Water;
    [SerializeField] MeshRenderer Plant;
    [SerializeField] MeshRenderer Land;
    [SerializeField] TaskTracker TaskTrack;
    [SerializeField] Material Plantw;
    [SerializeField] Material Landw;

    public int waterCounter;
    public bool amIWaterCounting;
    public bool waterStop;

    void Start()
    {
        waterCounter = 0;
        Water.SetActive(false);
        amIWaterCounting = false;
        waterStop = false;
    }

    void Update()
    {
        if (amIWaterCounting && !waterStop)
        {

            if (waterCounter >= 1000)
            {
                waterStop = true;
                Water.SetActive(false);
                Plant.material = Plantw;
                Land.material = Landw;
                TaskTrack.taskTracker ++;

            }
            else
            {
                waterCounter++;
            }




        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Plants") && !waterStop)
        {

            Water.SetActive(true);
            amIWaterCounting = true;

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if ((other.tag == "Plants") && !waterStop)
        {
            Water.SetActive(false);
            amIWaterCounting = false;

        }

    }

}
