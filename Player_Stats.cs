using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player_Stats : MonoBehaviour
{
    public TextMeshProUGUI playerhealth;

    public float Player_Health = 100f;
    public float Player_Speed = 5f;
    public int Player_Livees = 3;

    private void Update()
    {
        playerhealth.text = Player_Health.ToString();
    }
}
