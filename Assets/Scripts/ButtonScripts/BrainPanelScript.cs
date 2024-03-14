using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrainPanelScript : MonoBehaviour
{
    public GameObject BrainPanel;

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenBrainPanel()
    {
        BrainPanel.SetActive(true);
        //Time.timeScale = 0;
    }

    public void CloseBrainPanel()
    {
        BrainPanel.SetActive(false);
        //Time.timeScale = 1;
    }

    public void PlayBrainLevel()
    {
        SceneManager.LoadScene(4);
    }
}
