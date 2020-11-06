using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var missileTargetRot = Quaternion.LookRotation(player.position - transform.position);
        GetComponent<Rigidbody>().MoveRotation(Quaternion.RotateTowards(transform.rotation, missileTargetRot, 1.0f));
        enemy.SetDestination(player.position);
    }
}
