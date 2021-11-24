using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Move : MonoBehaviour
{
    public CharacterController controller;
 
    public float PlayerSpeed = 12f;
    public float gravity = -9.81f;
    
    Vector3 velocity;

    public GameObject deathMenu;
    public GameObject winMenu;

    void Start()
    {
        controller.enabled = true;
    }
 
 
    void Update()
    {
        
        /*
        if(velocity.y < 0)
        {
            velocity.y = -2f;
        }
        */
 
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
 
        Vector3 move = transform.right * x + transform.forward * z;
 
        controller.Move(move * PlayerSpeed * Time.deltaTime);
 
        /*
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }
        */

        velocity.y += gravity * Time.deltaTime;
 
        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKeyDown("r"))
        { //If you press R
            SceneManager.LoadScene("SampleScene"); //Load scene called Game
        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        string objectname = collision.gameObject.tag;

        if (objectname == "enemy")
        {
            Time.timeScale = 0f;
            Debug.Log("dead");
            deathMenu.SetActive(true);
        }

        if (objectname == "finish")
        {
            Time.timeScale = 0f;
            Debug.Log("fin");
            winMenu.SetActive(true);
        }

    }

}

//ADD A PLAYER CONTROLLER TO THE PLAYER. 
//MAKE SURE THIS CONTROLLER IS LEVEL WITH THE PLAYERS FEET.


