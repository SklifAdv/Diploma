using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class DaytimeScript : MonoBehaviour
{
    private GameObject sunState;

    void Start()
    {
        sunState = GameObject.Find("SunState");
    }
    public void ChangeDaytime()
    {
        if (sunState != null)
        {
            sunState.transform.Rotate(45f, 0f, 0f);
        }
    }
}
