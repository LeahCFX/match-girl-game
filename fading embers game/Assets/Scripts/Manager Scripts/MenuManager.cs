using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject settingsMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void settingsBack()
    {
        settingsMenu.SetActive(false);
    }

    public void settingsOpen()
    {
        settingsMenu.SetActive(true);
    }
}
