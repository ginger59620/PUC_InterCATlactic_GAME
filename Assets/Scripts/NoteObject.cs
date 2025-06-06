using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;
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
                    Debug.Log("Hit");
                    GameManager.instance.NormalHit();
                }
                else if(transform.position.y > -27.73 || transform.position.y > -29.15)
                {
                    Debug.Log("Good Hit");
                    GameManager.instance.GoodHit();
                }
                else
                {
                    Debug.Log("Perfect Hit!");
                    GameManager.instance.PerfectHit();

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
        }
      
    }
    

}
