using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    public void quitApp()
    {
        Debug.Log("Quit successfully");
        Application.Quit();
    }
}
