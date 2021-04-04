using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject intro;
    void Update()
    {
        if(Input.anyKey)
        {
            intro.SetActive(false);
            mainMenu.SetActive(true);
        }
        
    }
}
