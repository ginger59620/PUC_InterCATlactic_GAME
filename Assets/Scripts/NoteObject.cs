using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;

    public GameObject coolEffect, sickEffect, bangerEffect, yikesEffect;

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

                //GameManager.instance.NoteHit();

                if(transform.position.y > -27.54 || transform.position.y > -29.38)
                {
                    //COOL HIT
                    GameManager.instance.CoolHit();
                    Instantiate(coolEffect, transform.position, coolEffect.transform.rotation);
                }
                else if(transform.position.y > -28 || transform.position.y > -29)
                {
                   //SICK HIT
                    GameManager.instance.SickHit();
                    Instantiate(sickEffect, transform.position, sickEffect.transform.rotation);
                }
                else if(transform.position.y > -28.28)
                {
                    //BANGER HIT
                    GameManager.instance.BangerHit();
                    Instantiate(bangerEffect, transform.position, bangerEffect.transform.rotation);
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
        else if (other.tag == "KILL")
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;

            GameManager.instance.NoteMissed();
            Instantiate(yikesEffect, transform.position, yikesEffect.transform.rotation);
        }
      
    }
    

}
