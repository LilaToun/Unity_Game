using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class QuitGame : MonoBehaviour
{
     public GameObject quitPanel;


    public void Quit_Game()
    {
        Application.Quit();
        print("Quit");

    }

    public void OnUserClickYesNo(int choice)
    {
        if (choice == 1) // Yes button
        {
            Application.Quit();
            print("Quit");
        }
        quitPanel.SetActive(false);
    }

}
