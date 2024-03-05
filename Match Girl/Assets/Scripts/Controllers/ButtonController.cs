using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public GameController gameController;
    private Animator animator;
    public MidButtonController controller;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void SetUp(ButtonScene.CustomButton button)
    {
        controller.SetUp(button);
        animator.SetTrigger("Show");
    }

    public void NewGame(string gameScene)
    {
        SceneManager.LoadScene(gameScene, LoadSceneMode.Single);
    }
}
