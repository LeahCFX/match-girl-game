using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideo : MonoBehaviour
{
    public GameObject videoPlayer;
    public int timetoStop;

    private void Awake()
    {
        videoPlayer.SetActive(false);
    }
    void Start()
    {
        videoPlayer.SetActive(true);
        Destroy(videoPlayer, timetoStop);
    }
}