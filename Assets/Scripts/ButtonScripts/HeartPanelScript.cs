using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeartPanelScript : MonoBehaviour
{
    public GameObject HeartPanel;

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenHeartPanel()
    {
        HeartPanel.SetActive(true);
        //Time.timeScale = 0;
    }

    public void CloseHeartPanel()
    {
        HeartPanel.SetActive(false);
        //Time.timeScale = 1;
    }

    public void PlayHeartLevel()
    {
        SceneManager.LoadScene(5);
    }
}
