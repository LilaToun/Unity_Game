using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosingDoor : MonoBehaviour
{
    //[SerializeField]
    //private Rigidbody _targetRigidbody;
private void OnCollisionEnter(Collision collision)
{
        GameObject door = GameObject.Find("Door_1");
        door.GetComponent<DoorSystem>().ChangeDoorState();
    }

/*private void OnTriggerEnter(Collider other)
{
    GameObject player = GameObject.Find("Player");
    player.GetComponent<InteractScript>().hit.collider.transform.parent.GetComponent<DoorSystem>().ChangeDoorState();
}*/
}
