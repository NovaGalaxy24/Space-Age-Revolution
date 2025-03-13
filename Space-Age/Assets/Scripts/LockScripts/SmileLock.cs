using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmileLock : MonoBehaviour
{

    public int slocks = 0;
    public LockCheck lockCheck;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (slocks == 4)
        {
           
            lockCheck.smileLock = true;
        }
    }

    public void AddSmileLock()
    {
        slocks = slocks + 1;
    }

    public void RemoveSmileLock()
    {
        slocks = slocks - 1;
    }

}
