using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeScript : MonoBehaviour
{


    public static float gameTime;
    public TextMeshProUGUI timeTracker;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameTime = Time.time;
        timeTracker.SetText(gameTime.ToString("0"));
    }

}
