using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_2 : MonoBehaviour
{
    public Transform player;
    public bool isInteract = true;
    public float interactDistance = 15f;
    public float smooth = 2f;

    public float moveSpeed = 10f;
    private Rigidbody rb;
    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        print("merde");
        if (Physics.Raycast(ray, out hit, interactDistance))
        {
            print("merde2");
            if (hit.transform.CompareTag("Player"))
            {
                print("merde3");
                transform.position = player.position;
            }
        }
    }

    private void FixedUpdate()
    {
        var direction = Quaternion.LookRotation(player.position - transform.position);
        rb.MoveRotation(Quaternion.RotateTowards(transform.rotation, player.rotation, 1.0f));
    }
}
