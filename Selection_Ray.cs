using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Selection_Ray : MonoBehaviour
{
    public GameObject selectedObject;
    public TextMeshProUGUI objectName;
    public TextMeshProUGUI GoldCounter;
    public TextMeshProUGUI Inventorytext;

    [SerializeField] public float gold;
    public int invspace;
    public int invMax;
    public Inventory inv;
    public GameObject arm;

    public int invlocal;
    
    public bool Invfull = false;

    public ParticleSystem Dusty;
    public Animator Arm_animator;
    // Start is called before the first frame update
    void Start()
    {
        inv = GameObject.FindAnyObjectByType<Inventory>();
        Arm_animator = arm.GetComponent<Animator>();
    }

    public void Update()
    {


        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1.5f))
        {
            if (hit.collider.gameObject.CompareTag("Resource"))
            {

                objectName.text = hit.collider.gameObject.GetComponent<ObjName>().Name;
            }
            else
            {
                objectName.text = "  ";
            }

            if (hit.collider.gameObject.CompareTag("Resource") && Invfull == false && Input.GetKeyDown(KeyCode.E))
            {
                Arm_animator.SetTrigger("Swing");
                Arm_animator.SetTrigger("Back To Idle");
                gold += hit.collider.gameObject.GetComponent<ObjName>().worth;
                invlocal = hit.collider.gameObject.GetComponent<ObjName>().invlocal;
                invspace += 1;
                Instantiate(Dusty, hit.point, this.transform.rotation);
                Destroy(hit.collider.gameObject);
                FindObjectOfType<AudioManager>().Play("Bing");
                IncreaseInv();
                CheckHighscore();
            }

        }

        GoldCounter.text = gold.ToString();
        Inventorytext.text = "Collected " + invspace.ToString() + " / " + invMax.ToString() + " Max";

    }

    public void CheckHighscore()
    {
        if (gold > PlayerPrefs.GetFloat("Highscore", 0));
        {
            PlayerPrefs.SetFloat("Highscore", gold);
        }
    }

    public void IncreaseInv()
    {

        inv.UseThisInt = invlocal;
        inv.increase();
        
        
    }

}
