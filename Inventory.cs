using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    public string UseThisName;
    public int UseThisInt;
    public int Worth;

    public TextMeshProUGUI[] names;
    public int[] Count;

    Selection_Ray selectray;

    private void Start()
    {
        selectray = GameObject.FindObjectOfType<Selection_Ray>();
    }


    public void Update()
    {
      

    }

    public void increase()
    {
        Count[UseThisInt] += 1;
        names[UseThisInt].text = Count[UseThisInt].ToString();
       
    }
    public void Decrease()
    {
        Count[UseThisInt] -= 1;
        names[UseThisInt].text = Count[UseThisInt].ToString();
        selectray.invspace -= 1;
        
    }
}

