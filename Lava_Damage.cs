using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava_Damage : MonoBehaviour
{
    public GameObject Player;

    public float timer;
    public bool timeron = false;
    public int multipler;

   
    public void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        
    }

 

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timeron = true;
            StartCoroutine(Damage());
            FindObjectOfType<AudioManager>().Play("Sizzle");
        }
    }
   

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timeron = false;
            FindObjectOfType<AudioManager>().Stop("Sizzle");
           

        }
    }

    IEnumerator Damage()
    {
        while (timeron == true)
        {
            
            Player.GetComponent<Player_Stats>().Player_Health -= 5;
            yield return new WaitForSeconds(1f);
        }
        
    }

    
   
}
