using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpaceController : MonoBehaviour
{
    Selection_Ray selectray;
    public GameObject invfull;
    void Start()
    {
        selectray = GameObject.FindObjectOfType<Selection_Ray>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (selectray.invspace >= selectray.invMax)
        {
            selectray.Invfull = true;
            invfull.SetActive(true);
        }
        else if (selectray.invspace <= selectray.invMax)
        {
            selectray.Invfull = false;
            invfull.SetActive(false);
        }
    }
}
