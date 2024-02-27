using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OrganSpot : MonoBehaviour
{
    public bool filled;
    public int spotID;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }
    void Update()
    {
        //Check for mouse click 
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);
                placeOrgan();
            }
        }
    }

    /*
  public void RemoveOrgan()
    {
        if(GameManager.SelectedOrganID == spotID)
        {
            spriteRenderer.gameObject.SetActive(false);
        }
    }
    */



    public void placeOrgan()
    {
        if(!filled)
        {
            if(GameManager.SelectedOrganID == spotID)
                {

                filled = true;
                spriteRenderer.enabled = false;
                GameManager.SelectedOrganID = 0;
                spriteRenderer.sprite = null;
            }
        }
    }









}
