using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationPanelScript : MonoBehaviour
{

    public GameObject InfoPanelOne;
    public GameObject InfoPanelTwo;
    public GameObject InfoPanelThree;
    public GameObject InfoPanelFour;
    public GameObject InfoPanelFive;
    public GameObject InfoPanelSix;
    public GameObject InfoPanelSeven;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showInfo(string nummer)
    {
        InfoPanelOne.SetActive(false);
        InfoPanelTwo.SetActive(false);
        InfoPanelThree.SetActive(false);
        InfoPanelFour.SetActive(false);
        InfoPanelFive.SetActive(false);
        InfoPanelSix.SetActive(false);
        InfoPanelSeven.SetActive(false);

        switch (nummer)
        {
            case "one":
                InfoPanelOne.SetActive(true);
                break;
            
            case "two":
                InfoPanelTwo.SetActive(true);
                break;

            case "three":
                InfoPanelThree.SetActive(true);
                break;

            case "four":
                InfoPanelFour.SetActive(true);
                break;

            case "five":
                InfoPanelFive.SetActive(true);
                break;

            case "six":
                InfoPanelSix.SetActive(true);
                break;

            case "seven":
                InfoPanelSeven.SetActive(true);
                break;

            default: 
                break;
        }
        



    }
}
