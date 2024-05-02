using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public GameObject fireballPrefab;
    private float counter = 5;
    private Vector3 lastMovement = Vector3.zero;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movement
        Vector3 movement = new Vector3(0,0,0);
        if (Input.GetKey("w"))
        {
            movement = movement + new Vector3(0f,1f,0f);
        }
        if (Input.GetKey("s"))
        {
            movement = movement + new Vector3(0f,-1f,0f);
        }
        if (Input.GetKey("a"))
        {
            movement = movement + new Vector3(-1f,0,0f);
        }
        if (Input.GetKey("d"))
        {
            movement = movement + new Vector3(1f,0,0f);
        }

        movement = movement.normalized;

        transform.position = transform.position + movement * Time.deltaTime * 2;

        if (movement.y != 0 || movement.x != 0)
        {
            lastMovement=movement;
            animator.SetBool("Walking", true);
        } else
        {
            animator.SetBool("Walking", false);
        }       
        if(movement.x < 0)
        {
            transform.localScale = new Vector3(-1,1,1);
        } 
        if(movement.x > 0)
        {
            transform.localScale = new Vector3(1,1,1);
        } 

        //GetKomponent<Fireball>().
        // Casting
        counter += Time.deltaTime;
        if (counter > 1 && Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj = Instantiate(fireballPrefab, transform.position, Quaternion.identity);
            obj.GetComponent<Fireball>().direction = lastMovement;
            counter = 0;
        }

        
    }
}