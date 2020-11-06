using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractScript : MonoBehaviour
{
    public bool isInteract = true;
    public float interactDistance = 1.5f;
    public float smooth = 2f;




    void Update()
    {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, interactDistance))
            {
                if (hit.transform.CompareTag("Missile"))
                {
                    GameObject missile = GameObject.Find("Missile");
                    missile.transform.SetParent(GameObject.Find("Player").transform);
                    missile.GetComponent<Missile>().SetReady();
                }
            }

            

            if (GameObject.Find("HealthBar").GetComponent<HealthBar>().CurrentHealth() == 0)
             {
                Application.Quit();
                print("quit");
             }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GameObject.Find("HealthBar").GetComponent<HealthBar>().ChangeHealthProgress(-20);
        }
        if (collision.gameObject.CompareTag("Life"))
        {
            GameObject.Find("HealthBar").GetComponent<HealthBar>().ChangeHealthProgress(20);
        }
        if((collision.gameObject.CompareTag("Hole_1")) || (collision.gameObject.CompareTag("Hole_2"))|| (collision.gameObject.CompareTag("Hole_3")) ||
            (collision.gameObject.CompareTag("Hole_4")) || (collision.gameObject.CompareTag("Hole_5")))
        {
            GameObject.Find("HealthBar").GetComponent<HealthBar>().ChangeHealthProgress(-20);
        }
        if (collision.gameObject.CompareTag("Lave"))
        {
            Invoke("Fct", 1);
        }
    }

    private void Fct()
    {
        GameObject.Find("HealthBar").GetComponent<HealthBar>().ChangeHealthProgress(-20);
        transform.position = new Vector3(-79.1f, 0.62f, 16.73f);
    }
}
