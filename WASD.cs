using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour
{
   
    float mousesens = 100f;
    public Transform player;

    float XRotation = 0f;
    
    

    // Start is called before the first frame update
    void Start()
    {
      
        Cursor.lockState = CursorLockMode.Locked;

          
    }

    // Update is called once per frame
    void Update()
    {
      

        float mousex = Input.GetAxis("Mouse X") * mousesens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mousesens * Time.deltaTime;

        XRotation -= mouseY;
        XRotation = Mathf.Clamp(XRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(XRotation, 0f, 0f);
        player.Rotate(Vector3.up * mousex);

        
    }
}
