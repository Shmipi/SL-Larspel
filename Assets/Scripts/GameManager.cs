using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score;
    public static int time;
    public static List<GameObject> gameObjects = new List<GameObject>();
    public OrganSpot[] organSpots;
    public  List<Sprite> spriteList = new List<Sprite> ();
    public static int SelectedOrganID;
    private int nrOfSpots;


    
    // Start is called before the first frame update
    void Start()
    {
        organSpots = FindObjectsOfType<OrganSpot>();
        for(int i = 0; i < organSpots.Length; i++)
        {
            nrOfSpots++;
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

        for(int i = 0;i < organSpots.Length;i++)
        {
            if (organSpots[i].filled == true) {
                nrCompleted++;
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
    }
}
