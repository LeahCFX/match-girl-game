using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class MidButtonController : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public TextMeshProUGUI buttonText;
    public Color hoverColor;
    public ButtonController controller;
    private string gameScene;

    public void SetUp(ButtonScene.CustomButton button)
    {
        buttonText.text = button.text;
        gameScene = button.gameScene;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        controller.NewGame(gameScene);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonText.color = hoverColor;

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonText.color = Color.white;
    }

}
