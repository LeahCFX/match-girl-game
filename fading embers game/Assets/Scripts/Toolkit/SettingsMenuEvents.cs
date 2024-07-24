using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SettingsMenuEvents : MonoBehaviour
{
    private UIDocument _document;
    private Button _button;

    private void Awake()
    {
        _document = GetComponent<UIDocument>();

        _button = _document.rootVisualElement.Q("BackButton") as Button;
        _button.RegisterCallback<ClickEvent>(BackButton_Click);
    }

    private void OnEnable()
    {
        _document = GetComponent<UIDocument>();
        _button = _document.rootVisualElement.Q("BackButton") as Button;
        _button.RegisterCallback<ClickEvent>(BackButton_Click);
    }

    private void OnDisable()
    {
        _button.UnregisterCallback<ClickEvent>(BackButton_Click);
    }

    private void BackButton_Click(ClickEvent e)
    {
        gameObject.SetActive(false);
    }
}
