using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryMenuScript : MonoBehaviour
{
    string currentSceneName;
    // Start is called before the first frame update
    void Start()
    {
       currentSceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Menu()
    {
        SceneManager.LoadScene("Body");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(currentSceneName);
    }
}
