using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_L5 : MonoBehaviour
{
    [SerializeField]

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.Find("Light").GetComponent<EnabledLight>().changeStateLight();
        }
    }
}
