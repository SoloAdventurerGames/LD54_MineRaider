using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropInv : MonoBehaviour
{
    public int invlocal;
    Inventory inv;
    public int Worth;
    Selection_Ray SelectRay;
    public void Start()
    {

        SelectRay = GameObject.FindObjectOfType<Selection_Ray>();
        inv = GameObject.FindObjectOfType<Inventory>();
    }
    public void Drop()
    {
        inv.UseThisInt = invlocal;
        SelectRay.gold -= Worth;
        inv.Decrease();
       
    }
    
}
