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
        Invoke("Play", NoteSpawnManager.instance.noteFallingTime); // 노트가 노트 히터에 닿기까지 계산한 시간이 지난후에 실행
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

    private void Play()
    {
        _videoPlayer.Play();
    }

}
