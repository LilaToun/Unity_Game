using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public Transform missileTarget;
    public Rigidbody missileRgb;
    //public float turnSpeed = 1f;
    public float missileSpeed = 10f;
    private Transform missileLocalTrans;
    private bool ready = false;



    public void Start()
    {
        missileLocalTrans = GetComponent<Transform>();


    }

    public void SetReady()
    {
        ready = true;
    }

    private void FixedUpdate()
    {
        //Tourner le missile en direction de l'ennemi
        
        var missileTargetRot = Quaternion.LookRotation(missileTarget.position - missileLocalTrans.position);
        missileRgb.MoveRotation(Quaternion.RotateTowards(missileLocalTrans.rotation, missileTargetRot, 1.0f));

        if (Input.GetButtonDown("Fire1") && ready == true)
        {
            //Transform missileTrans = GetComponent<Transform>();
            missileRgb.velocity = missileLocalTrans.forward * missileSpeed;

            missileRgb.isKinematic = false;
            missileRgb.AddForce(Vector3.up * 400f);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
        }
    }
}
