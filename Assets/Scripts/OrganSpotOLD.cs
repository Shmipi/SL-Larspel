using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OrganSpotOLD : MonoBehaviour
{
    public bool filled;
    public int spotID;
    private SpriteRenderer spriteRenderer;
    public AudioClip GoodClip;
    public AudioClip WrongClip;
    private AudioSource audioSource;
    public ParticleSystem particles;
    public ParticleSystem badParticles;
    private GameManager gameManager;


   

    // Start is called before the first frame update
    void Start()
    {
     
       
       
        gameManager = FindObjectOfType<GameManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        //Check for mouse click 
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider == gameObject.GetComponent<Collider2D>())
            {
                Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);
                placeOrgan();
            }
        }
    }




    public void placeOrgan()
    {
        if(!filled)
        {
            if(GameManager.SelectedOrganID == spotID)
                {

                filled = true;
               // spriteRenderer.enabled = false;
                GameManager.SelectedOrganID = 0;
                spriteRenderer.sprite = gameManager.GetComponent<GameManager>().spriteList[spotID - 1];

                gameManager.CheckGameState();

                PlaySound(true);
                PlayVFX(true);
            }
            else
            {
                PlaySound(false);
                PlayVFX(false);


            }
        }
    }




    public void PlaySound(bool feedback)
    {
        if(feedback)
        {
            {
                audioSource.clip = GoodClip;
                audioSource.Play();
            } }
        else
        {
            audioSource.clip = WrongClip;
            audioSource.Play();
        }



    }

    public void PlayVFX(bool feedback)
    {
        if (feedback == true)
        {
            {

                particles.Emit(5);
            }
        }
        else
        {
            badParticles.Emit(5);
            Debug.Log("fel");
        }


    }


}
