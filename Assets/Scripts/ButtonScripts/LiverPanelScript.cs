using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiverPanelScript : MonoBehaviour
{
    public GameObject LiverPanel;

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenLiverPanel()
    {
        LiverPanel.SetActive(true);
        //Time.timeScale = 0;
    }

    public void CloseLiverPanel()
    {
        LiverPanel.SetActive(false);
        //Time.timeScale = 1;
    }

    public void PlayLiverLevel()
    {
        //SceneManager.LoadScene(0);
    }
}
