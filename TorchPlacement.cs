using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TorchPlacement : MonoBehaviour
{
    public TextMeshProUGUI Objectname;
    public TextMeshProUGUI Torches;
    public GameObject Torch;
    public GameObject torchSpawner;
    public int Torchcount = 10;
    void Start()

    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Torchcount >= 1 && Input.GetKeyDown(KeyCode.F))
        {

            Instantiate(Torch, torchSpawner.transform.position, Torch.transform.rotation);
            Torchcount -= 1;

        }
        
        if (Torchcount <= 5)
        {
            Objectname.text = Torchcount.ToString() + " Torches Remaining";

        }
        else if (Torchcount <= 0)
        {
            Objectname.text = "Out Of Torches";
        }


        Torches.text = Torchcount.ToString();
    }
}

