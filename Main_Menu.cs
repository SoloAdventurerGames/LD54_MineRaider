using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Main_Menu : MonoBehaviour
{
    [SerializeField] Slider VolumeSlider;

    public GameObject Instructionsmenu;
    public bool CloseInstuctions;

    public GameObject ValueChart;
    public bool CloseValuechart;
    public void playGame()
    {
        SceneManager.LoadScene(1);
    }

   
    public void Exit()
    {
        Application.Quit();
    }

    public void Instructions()
    {
        
        Instructionsmenu.SetActive(CloseInstuctions = !CloseInstuctions);
    }

    public void Value()
    {
        ValueChart.SetActive(CloseValuechart = !CloseValuechart);
        
    }

    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }
    

}
