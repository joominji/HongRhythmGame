using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SongSelector : MonoBehaviour
{
    [SerializeField] private string songName;
    private Button _button;

    public void SelectSong()
    {
        GameManager.instance.songSelected = songName;
    }

    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(SelectSong);
    }
}
