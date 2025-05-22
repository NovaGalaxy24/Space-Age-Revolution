using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DayControl : MonoBehaviour
{
    public string NextDay;

    public void NextScene()
    {
        SceneManager.LoadScene(NextDay);
    }
}
