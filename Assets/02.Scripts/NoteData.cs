using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 어떤 키에 해당하는 노트가 몇초 뒤에 떨어져야 하는지에 대한 데이터
/// </summary>
[Serializable]
public struct NoteData
{
    public KeyCode key;
    public float time;
}
