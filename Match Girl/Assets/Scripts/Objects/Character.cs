using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacter", menuName = "Data/New Character")]
[System.Serializable]
public class Character : ScriptableObject
{
    public string speakerName;
    public Color textColor;
}

