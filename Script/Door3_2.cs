using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door3_2 : MonoBehaviour
{
    public bool open = false;
    public bool close = false;
    public float doorOpenAngle = 90.0f;
    public float doorCloseAngle = 0f;
    public float smooth = 2f;

    void Start()
    {
        Quaternion targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
