using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD1 : MonoBehaviour
{
    // horde script


    float speed ;
    public float jump = 250f;
    Rigidbody Rigid;

    Collider col;

   
    public bool isgrounded;
    Player_Stats playerStats;
    public GameObject InventoryPanel;

    public bool Inventoryactive = false;

    public GameObject MainMenu;
    public bool Main_Menu_On;

   

    // Start is caled before the first frame updte
    void Start()
    {
        Rigid = GetComponent<Rigidbody>();
        speed = 5.0f;
        col = GetComponent<Collider>();
        playerStats = GameObject.FindObjectOfType<Player_Stats>();
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = playerStats.Player_Speed;


        if (Input.GetKey(KeyCode.W))
        { 
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        
       if (isgrounded == true)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigid.AddForce(transform.up  * jump);
                isgrounded = false;
            }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerStats.Player_Speed = speed * 2;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerStats.Player_Speed = 2;
        }

        if (Inventoryactive == false && Input.GetKeyDown(KeyCode.I))
        {
            InventoryPanel.SetActive(true);
            Inventoryactive = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
        else if (Inventoryactive == true && Input.GetKeyDown(KeyCode.I))
        {
            InventoryPanel.SetActive(false);
            Inventoryactive = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (Main_Menu_On == false && Input.GetKeyDown(KeyCode.Escape))
        {
            MainMenu.SetActive(true);
            Main_Menu_On = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
        else if (Main_Menu_On == true && Input.GetKeyDown(KeyCode.Escape))
        {
            MainMenu.SetActive(false);
            Main_Menu_On = false;
            Cursor.lockState = CursorLockMode.Locked; 
        }
        

    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isgrounded = true;
        }
     
    }
}

