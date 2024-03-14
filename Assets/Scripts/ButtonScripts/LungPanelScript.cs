using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LungPanelScript : MonoBehaviour
{
    public GameObject LungPanel;

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenLungPanel()
    {
        LungPanel.SetActive(true);
        //Time.timeScale = 0;
    }

    public void CloseLungPanel()
    {
        LungPanel.SetActive(false);
        //Time.timeScale = 1;
    }

    public void PlayLungLevel()
    {
        //SceneManager.LoadScene(0);
    }
}
