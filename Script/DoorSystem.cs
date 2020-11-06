using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSystem : MonoBehaviour
{
    public bool open = false;
    public bool close = false;
    public float doorOpenAngle = 90.0f;
    public float doorCloseAngle = 0f;
    public float smooth = 2f;

    //public Material Material1;


    public void ChangeDoorState()
    {
        open = !open;
        GetComponent<Renderer>().materials[0].color = Color.yellow;
        Material material2 = Resources.Load("New Material") as Material;
        GetComponent<MeshRenderer>().material = material2;
        //GetComponent<MeshRenderer>().material = Material1;
        GetComponent<AudioSource>().Play();
        
    }
  
    
    void Update()
    {
        if (open)
        {
            Quaternion targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth *Time.deltaTime);

        }
        else //To close the door
        {
            Quaternion targetRotation2 = Quaternion.Euler(0, doorCloseAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, smooth * Time.deltaTime);
        }
    }
}
