using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Win_Script : MonoBehaviour
{
    public GameObject Player;
    Inventory inventory;
    Selection_Ray selectray;
    public bool invfull = false;

    public float Timer;
    public bool Timer_on;

    public TextMeshProUGUI Time_Text;

    LavaRaise lava;

   private void Start()
    {
        inventory = GameObject.FindObjectOfType<Inventory>();
        selectray = GameObject.FindObjectOfType<Selection_Ray>();
        lava = GameObject.FindObjectOfType<LavaRaise>();
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (Timer_on == true)
        {
            if (Timer > 0)
            {
                Timer -= Time.deltaTime;
                timerupdate(Timer);
            }
            else
            {
                Timer = 0;
                Timer_on = false;
                lava.lava();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (selectray.invspace == selectray.invMax)
        {
            invfull = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (invfull == true)
        {
           
            SceneManager.LoadScene(2);
            Cursor.lockState = CursorLockMode.Confined;
            FindObjectOfType<AudioManager>().Stop("Sizzle");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        
        
            Timer_on = true;
        
    }

    void timerupdate(float Current_Time)
    {
        Current_Time += 1;

        float minutes = Mathf.FloorToInt(Current_Time / 60);
        float seconds = Mathf.FloorToInt(Current_Time % 60);
        Time_Text.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
