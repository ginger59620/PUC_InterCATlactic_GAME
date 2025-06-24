using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;

    public GameObject coolEffect, sickEffect, bangerEffect, yikesEffect;

    public Transform effectSpawnPoint;

    public AudioSource hitHits;
    public AudioSource missHits;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(keyToPress))
        {
            if(canBePressed)
            {
                gameObject.SetActive(false);
                hitHits.Play();

                //GameManager.instance.NoteHit();

                if (transform.position.y > -27 || transform.position.y > -29.38)
                {
                    //COOL HIT
                    GameManager.instance.CoolHit();
                    Instantiate(coolEffect, effectSpawnPoint.position, coolEffect.transform.rotation);
                }
                else if(transform.position.y > -28 || transform.position.y > -29)
                {
                   //SICK HIT
                    GameManager.instance.SickHit();
                    Instantiate(sickEffect, effectSpawnPoint.position, sickEffect.transform.rotation);
                }
                else if(transform.position.y > -28.28)
                {
                    //BANGER HIT
                    GameManager.instance.BangerHit();
                    Instantiate(bangerEffect, effectSpawnPoint.position, bangerEffect.transform.rotation);
                }
                
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;

            GameManager.instance.NoteHit();
        }
      
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;
            missHits.Play();

            GameManager.instance.NoteMissed();
            Instantiate(yikesEffect, effectSpawnPoint.position, yikesEffect.transform.rotation);
        }
      
    }
    

}
