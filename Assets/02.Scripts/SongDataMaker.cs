using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
public class SongDataMaker : MonoBehaviour
{
    private KeyCode[] _keys = { KeyCode.S, KeyCode.D, KeyCode.F, KeyCode.Space, KeyCode.J, KeyCode.K, KeyCode.L };
    private SongData _songData;
    private VideoPlayer _videoPlayer;
    private bool _isRecording;

    public void StartRecording()
    {
        if (_isRecording)
        {
            return;
        }
        _isRecording = true;
        _songData = new SongData();
        _videoPlayer.Play();
    }

    public void SaveRecording()
    {

    }

    private void Update()
    {
        if (_isRecording)
        {
            Recording();
        }
    }

    private void Recording()
    {
        foreach (KeyCode key in _keys)
        {
            if (Input.GetKeyDown(key))
            {
                _songData.notes.Add(CreateNoteData(key));
            }
        }
    }

    private NoteData CreateNoteData(KeyCode key)
    {
        NoteData noteData = new NoteData()
        {
            key = key,
            time = (float)System.Math.Round(_videoPlayer.time, 2)
        };

        return noteData;
    }
}
