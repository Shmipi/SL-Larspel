using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score;
    public static int time;
    public static List<GameObject> gameObjects = new List<GameObject>();
    public static int SelectedOrganID;


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(SelectedOrganID);
    }
}
