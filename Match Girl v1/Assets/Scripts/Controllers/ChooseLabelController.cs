using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChooseLabelController : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Color hoverColor;
    public StoryScene scene;
    private Image item;
    private ChooseController controller;
    private bool clicked;

    // Start is called before the first frame update
    void Awake()
    {
        item = GetComponent<Image>();
    }

    public void Setup(ChooseScene.ChooseLabel label, ChooseController controller)
    {
        scene = label.nextScene;
        item.sprite = label.item;
        clicked = label.clicked;
        this.controller = controller;
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        if (!clicked)
        {
            controller.PerformChoose(scene);
            clicked = true;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!clicked) 
        { 
            item.color = hoverColor;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        item.color = Color.white;
    }
}
