﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapLevel4 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
