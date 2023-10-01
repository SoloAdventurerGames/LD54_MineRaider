using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class player_death : MonoBehaviour
{
    public bool playerdead;
    Player_Stats playerstat;
    Selection_Ray SelectRay;
    Inventory inv;
    public GameObject player;
    public GameObject spawn;
    Lava_Damage LavaDamage;

    private void Start()
    {
        playerstat = GameObject.FindObjectOfType<Player_Stats>();
        SelectRay = GameObject.FindObjectOfType<Selection_Ray>();
        inv = GameObject.FindObjectOfType<Inventory>();
        LavaDamage = GameObject.FindObjectOfType<Lava_Damage>();
    }
    public void Update()
    {
        if (playerstat.Player_Health <= 0)
        {
            player.transform.position = spawn.transform.position;
            playerstat.Player_Livees -= 1;
            playerstat.Player_Health = 100f;
            SelectRay.invspace = 0;
            SelectRay.gold = 0;
            inv.Count[0] = 0;
            inv.Count[1] = 0;
            inv.Count[2] = 0;
            inv.Count[3] = 0;
            inv.Count[4] = 0;
            LavaDamage.timeron = false;


        }
        if (playerstat.Player_Livees <= 0)
        {
            Cursor.lockState = CursorLockMode.Confined;
            SceneManager.LoadScene(3);
        }
    }
}
