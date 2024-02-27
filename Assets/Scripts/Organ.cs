using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class Organ : MonoBehaviour
{

    [SerializeField] private int organID;
    [SerializeField] private string organName;
    [SerializeField] private string organDescription;
    [SerializeField] private Sprite organSprite;

    public TMPro.TextMeshPro textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void DisplayDescription()
    {
        textMeshPro.text = organDescription;
        
    }

    public void StopDisplayDescription()
    {
        textMeshPro.text = null;
        
    }
}
