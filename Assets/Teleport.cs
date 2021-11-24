using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget; //The variable for the teleport position
    public GameObject thePlayer; //the variable for teleporting the player

    void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
        //the trigger makes one position equal to another
    }

    /*
     
     on object your going to colide with enable istrigger
    Make sure that “Auto Sync Transforms” in the Physics section of Project Settings (which can be accessed from Edit) is enabled







    */
}
