using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
public class MVPlayer : MonoBehaviour
{
    private VideoPlayer _videoPlayer;
    public static MVPlayer instance;

    public void Play(VideoClip clip)
    {
        _videoPlayer.clip = clip;
        _videoPlayer.Play();
    }

    public void Stop()
    {
        _videoPlayer.Stop();
        _videoPlayer.clip = null;
    }

    private void Awake()
    {
        instance = this;
        _videoPlayer = GetComponent<VideoPlayer>();
    }


}