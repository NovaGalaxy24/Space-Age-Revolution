using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class CreditsRoll : MonoBehaviour
{

    public UnityEvent MoveOn;
    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(wait());
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(20);
        MoveOn.Invoke();   
    }
}
