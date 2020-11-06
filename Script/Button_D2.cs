using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_D2 : MonoBehaviour
{
    [SerializeField]

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject door = GameObject.Find("Door_2");
            door.GetComponent<DoorSystem>().ChangeDoorState();
        }
        
    }
}
