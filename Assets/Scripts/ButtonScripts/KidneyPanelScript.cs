using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KidneyPanelScript : MonoBehaviour
{
    public GameObject KidneyPanel;

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenKidneyPanel()
    {
        KidneyPanel.SetActive(true);
        //Time.timeScale = 0;
    }

    public void CloseKidneyPanel()
    {
        KidneyPanel.SetActive(false);
        //Time.timeScale = 1;
    }

    public void PlayKidneyLevel()
    {
        //SceneManager.LoadScene(0);
    }
}
