using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EqualLock : MonoBehaviour
{

    public int elocks = 0;
    public LockCheck lockCheck;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (elocks == 4)
        {
           
            lockCheck.equalLock = true;
        }
    }

    public void AddEqualLock()
    {
        elocks = elocks + 1;
    }

    public void RemoveEqualLock()
    {
        elocks = elocks - 1;
    }

}
