using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCatcher : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameStatus.IncreaseBadCount();
        HitAlertManager.instance.PopUp(NoteHitter.HitRange.Bad);
        Destroy(collision.gameObject);
    }
}
