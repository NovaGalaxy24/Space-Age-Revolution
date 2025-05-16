using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KillYourself : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(wait());
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }

}
