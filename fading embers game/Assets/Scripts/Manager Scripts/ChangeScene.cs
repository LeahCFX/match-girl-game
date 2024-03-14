using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] string sceneToLoad = "";
    //Load Scene by scene name
    public void LoadByString()
    {
        SceneManager.LoadScene("Scenes/" + sceneToLoad);
    }
}
