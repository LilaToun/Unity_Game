using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Button_D1 : MonoBehaviour
{
    [SerializeField]
 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject door = GameObject.Find("Door_1");
            door.GetComponent<DoorSystem>().ChangeDoorState();
        }
    }

}

