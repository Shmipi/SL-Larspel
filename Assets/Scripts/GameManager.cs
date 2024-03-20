using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int score;
    public static float time;
    public static int timeScore;
    public static int victoryTime;
    public static int victoryScore;
    public static List<GameObject> gameObjects = new List<GameObject>();
    public OrganSpotOLD[] organSpotsOld;
    public OrganSpot[] organSpots;
    public  List<Sprite> spriteList = new List<Sprite> ();
    public static int SelectedOrganID;
    private int nrOfSpots;
    private bool organSpotsBool;
    public GameObject VictoryPanel;
    public TextMeshProUGUI scoreTracker;
    public TextMeshProUGUI timeTracker;
    public TextMeshProUGUI finalTime;
    public TextMeshProUGUI finalScore;


    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        timeScore = 0;
        victoryTime = 0;
        victoryScore = 0;
        organSpotsOld = FindObjectsOfType<OrganSpotOLD>();
        organSpots = FindObjectsOfType<OrganSpot>();
        score = 0;

        if (organSpotsOld != null )
        {
            organSpotsBool = false;
            for (int i = 0; i < organSpotsOld.Length; i++)
            {
                nrOfSpots++;
            }
        }

        if (organSpots != null)
        {
            organSpotsBool = true;
            for (int i = 0; i < organSpots.Length; i++)
            {
                nrOfSpots++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(SelectedOrganID);
        time += Time.deltaTime;
        timeTracker.SetText("Time: " + time.ToString("0"));
    }

    public void CheckGameState()
    {
        int nrCompleted = 0;

        if(organSpotsOld != null)
        {
            
            for (int i = 0; i < organSpotsOld.Length; i++)
            {
                if (organSpotsOld[i].filled == true)
                {
                    nrCompleted++;
                    
                }
            }
        }

        if (organSpots != null) 
        {
            for (int i = 0; i < organSpots.Length; i++)
            {
                if (organSpots[i].filled == true)
                {
                    nrCompleted++;
                }

            }
        }
        Debug.Log("Nr Completed: " + nrCompleted);
        Debug.Log("Nr of Slots: " + nrOfSpots);
        score += 50;
        scoreTracker.SetText("Score: " + score.ToString());

        if (nrCompleted >= nrOfSpots)
        {
            Victory();
        }
    }

    private void Victory()
    {
        victoryTime = (int)time;
        timeScore = 400 - victoryTime*10;
        victoryScore = score+timeScore;

        Debug.Log("Victory");
        if(VictoryPanel != null)
        {
            VictoryPanel.SetActive(true);
            scoreTracker.SetText("Score: " + victoryScore.ToString());
            finalScore.SetText("Score: " + victoryScore.ToString());
            finalTime.SetText("Time: " + victoryTime.ToString());

        }

       

    }
}
