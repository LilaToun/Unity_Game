using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isOpened = false;
    public float speed = 2f;
    public Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        target = new Vector3(transform.position.x,
            -2.2f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpened)
        {
            transform.position = Vector3.MoveTowards(transform.position,
                target, speed * Time.deltaTime);
        }
    }
}
