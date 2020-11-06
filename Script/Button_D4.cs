using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_D4 : MonoBehaviour
{
    [SerializeField]

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject door = GameObject.Find("Door_4");
            door.GetComponent<DoorSystem>().ChangeDoorState();
            Invoke("Lila", 0);
        }
    }

    private void Lila()
    {
        GameObject.Find("Light").GetComponent<EnabledLight>().changeStateLight();
    }
}
