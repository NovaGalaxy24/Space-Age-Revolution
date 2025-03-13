using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountLock : MonoBehaviour
{

    public int mlocks = 0;
    public LockCheck lockCheck;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (mlocks == 4)
        {
           
            lockCheck.mountLock = true;
        }
    }

    public void AddMountLock()
    {
        mlocks = mlocks + 1;
    }

    public void RemoveMountLock()
    {
        mlocks = mlocks - 1;
    }

}
