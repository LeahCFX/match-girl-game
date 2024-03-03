using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "NewButtonScene", menuName = "Data/New Button Scene")]
[System.Serializable]
public class ButtonScene : GameScene
{
    public CustomButton button;

    [System.Serializable] 
    public struct CustomButton
    {
        public string text;
        public string gameScene;
    }

}
