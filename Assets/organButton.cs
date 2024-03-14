using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class organButton : MonoBehaviour
{
    public int organID;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

        //KANSKE TA MED DET HÄR IDK
       // gameObject.GetComponent<Image>().sprite = gameManager.GetComponent<GameManager>().spriteList[organID - 1];

        // gameObject.GetComponent<Button>().onClick.
        
    }  

    // Update is called once per frame
    void Update()
    {
        
    }   

    public void OnClick()
    {
        if(GameManager.SelectedOrganID == organID)
        {
            GameManager.SelectedOrganID = 0;    
        }
        else
        {
            GameManager.SelectedOrganID = organID;
        }
       
    }
}
