using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_D3 : MonoBehaviour
{
    [SerializeField]
 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject door = GameObject.Find("Door_3");
            door.GetComponent<DoorSystem>().ChangeDoorState();
        }
    }
}
