using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int score;
    public static int time;
    public static List<GameObject> gameObjects = new List<GameObject>();
    public OrganSpotOLD[] organSpotsOld;
    public OrganSpot[] organSpots;
    public  List<Sprite> spriteList = new List<Sprite> ();
    public static int SelectedOrganID;
    private int nrOfSpots;
    private bool organSpotsBool;
    public GameObject VictoryPanel;

    
    // Start is called before the first frame update
    void Start()
    {
        organSpotsOld = FindObjectsOfType<OrganSpotOLD>();
        organSpots = FindObjectsOfType<OrganSpot>();

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

        if (nrCompleted >= nrOfSpots)
        {
            Victory();
        }
    }

    private void Victory()
    {
        Debug.Log("Victory");
        if(VictoryPanel != null)
        {
            VictoryPanel.SetActive(true);
        }

       

    }
}
