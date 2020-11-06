using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private bool doorOpened;
    private bool coroutineAllowed;
    private GameObject door;

   

    void Start()
    {  

        doorOpened = false;
        coroutineAllowed = true;
    }

    private void RunCoroutine()
    {
        StartCoroutine("OpenThatDoor  ");
    }

    private IEnumerator OpenThatDoor()
    {
        coroutineAllowed = false;
        if (!doorOpened)
        {
            for (float i = 0f; i <= 150f; i += 10f)
            {
                transform.rotation = Quaternion.Euler(0f, i, 0f);
                yield return new WaitForSeconds(0f);
            }
            doorOpened = true;
        }
        else
        { 
            for (float i = 150f; i >= 0f; i -= 10f)
            {
                transform.rotation = Quaternion.Euler(0f, i, 0f);
                yield return new WaitForSeconds(0f);
            }
            doorOpened = false;
        }
        coroutineAllowed = true;
    } 

    private void OnDestroy()
    {
        //Button.ButtonPressed -= RunCoroutine;
    }
}
