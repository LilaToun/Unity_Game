using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnabledLight : MonoBehaviour
{
    private Light myLight;
    public bool switchOff;
    public bool s;
    public float intensity;
    void Start()
    {
        myLight = GetComponent<Light>();
        switchOff = false;
    }
     public void changeStateLight()
    {
        switchOff = !switchOff;
    }

    void Update()
    {
        if (switchOff)
        {
            myLight.intensity = 0f;
        }
        else
        {
            if (myLight.intensity < 1.0f)
            {
                myLight.intensity += 0.01f;
                if(myLight.intensity > 1.0f)
                {
                    Destroy(GameObject.Find("lamp"));
                    Destroy(GameObject.Find("Cube"));
                    GameObject.Find("FinalEnemy").SetActive(true);
                }
            }
        }
        
    }
}
