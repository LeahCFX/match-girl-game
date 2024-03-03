using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[CreateAssetMenu(fileName = "NewVideoScene", menuName = "Data/New Video Scene")]
[System.Serializable]
public class VideoScene : GameScene
{
    public VideoPlayer player;
    public VideoClip clip;
    public GameScene nextScene;
}
