using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))] // 이 스크립트를 컴포넌트로 추가했을때 VideoPlayer가 자동으로 생김
public class SongDataMaker : MonoBehaviour
{
    private KeyCode[] _keys = { KeyCode.S, KeyCode.D, KeyCode.F, KeyCode.J, KeyCode.K, KeyCode.L };
    private SongData _songData;
    private VideoPlayer _videoPlayer;
    private bool _isRecording;

    // 녹화시작
    public void StartRecording()
    {
        if (_isRecording)
        {
            return;
        }
        _isRecording = true;
        _songData = new SongData(_videoPlayer.clip.name);
        _videoPlayer.Play();
    }

    // 녹화종료
    public void StopRecording()
    {
        if (_isRecording == false)
        {
            return;
        }
        _videoPlayer.Stop();
        SaveRecording();
        _songData = null;
    }

    // 녹화저장
    public void SaveRecording()
    {
        string dir = UnityEditor.EditorUtility.SaveFilePanelInProject("노래 데이터 저장", _songData.name, "json", "");
        System.IO.File.WriteAllText(dir, JsonUtility.ToJson(_songData));
    }

    private void Awake()
    {
        _videoPlayer = GetComponent<VideoPlayer>();
    }

    private void Update()
    {
        if (_isRecording)
        {
            Recording();
        }
    }

    // 녹화에 관한 함수
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

    // 노트데이터를 생성하는 함수 (뮤비 재생시간에 대한 키값)
    private NoteData CreateNoteData(KeyCode key)
    {
        NoteData noteData = new NoteData()
        {
            key = key,
            time = (float)System.Math.Round(_videoPlayer.time, 2)
        };
        Debug.Log($"[SongDataMaker] : NoteData 생성됨, {noteData.key} {noteData.time}");

        return noteData;
    }
}
