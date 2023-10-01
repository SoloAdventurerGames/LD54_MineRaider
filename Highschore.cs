using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Highschore : MonoBehaviour
{
    Selection_Ray selectray;
    public TextMeshProUGUI highScoreText;
    public float GoldScore;

    private void Start()
    {
        GoldScore = GameObject.FindObjectOfType<Selection_Ray>().gold;
    }
    private void Update()
    {
            
        highScoreText.text = "Highscore: " + PlayerPrefs.GetFloat("Highscore");
    }
}
