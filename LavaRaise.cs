using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaRaise : MonoBehaviour
{
    public GameObject Lava;
    public GameObject LavaLevel;
    public bool timeup;
    Win_Script  Win;

    private void Start()
    {
        Win = GameObject.FindObjectOfType<Win_Script>();

    }

    private void Update()
    {
      if (timeup == true)
        { 
            Lava.transform.Translate(Vector3.up * .5f * Time.deltaTime); 
        }
      if (Lava.transform.position.y >= 0.7)
        {
            timeup = false;
        }
    }
    public void lava()
    {
        timeup = true;
    }

}
