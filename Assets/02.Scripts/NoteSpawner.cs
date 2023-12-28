using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    [SerializeField] private Note _note;
    public KeyCode key;
    private Color _color;

    private void Awake()
    {
        _color = GetComponent<SpriteRenderer>().color;
    }

    public void Spawn()
    {
        Note note = Instantiate(_note, transform.position, Quaternion.identity);
        note.GetComponent<SpriteRenderer>().color = _color;
        note.speed = PlaySettings.speed;
    }
}
