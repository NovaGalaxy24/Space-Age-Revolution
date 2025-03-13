using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowLock : MonoBehaviour
{

    public int alocks = 0;
    public LockCheck lockCheck;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (alocks == 4)
        {
           
            lockCheck.arrowLock = true;
        }
    }

    public void AddArrowLock()
    {
        alocks = alocks + 1;
    }

    public void RemoveArrowLock()
    {
       alocks = alocks - 1;
    }

}
