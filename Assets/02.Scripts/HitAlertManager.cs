using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAlertManager : MonoBehaviour
{
    public static HitAlertManager instance;
    [SerializeField] private PopUpText _bad;
    [SerializeField] private PopUpText _miss;
    [SerializeField] private PopUpText _good;
    [SerializeField] private PopUpText _great;
    [SerializeField] private PopUpText _perfect;

    private void Awake()
    {
        instance = this;
    }

    public void PopUp(NoteHitter.HitRange hitJudge)
    {
        if (_bad.gameObject.activeSelf)
            _bad.transform.Translate(Vector3.forward);
        if (_miss.gameObject.activeSelf)
            _miss.transform.Translate(Vector3.forward);
        if (_good.gameObject.activeSelf)
            _good.transform.Translate(Vector3.forward);
        if (_great.gameObject.activeSelf)
            _great.transform.Translate(Vector3.forward);
        if (_perfect.gameObject.activeSelf)
            _perfect.transform.Translate(Vector3.forward);

        switch (hitJudge)
        {
            case NoteHitter.HitRange.None:
                break;
            case NoteHitter.HitRange.Bad:
                {
                    _bad.PopUp();
                    _bad.transform.Translate(Vector3.back);
                }
                break;
            case NoteHitter.HitRange.Miss:
                {
                    _miss.PopUp();
                    _miss.transform.Translate(Vector3.back);
                }
                break;
            case NoteHitter.HitRange.Good:
                {
                    _good.PopUp();
                    _good.transform.Translate(Vector3.back);
                }
                break;
            case NoteHitter.HitRange.Great:
                {
                    _great.PopUp();
                    _great.transform.Translate(Vector3.back);
                }
                break;
            case NoteHitter.HitRange.Perfect:
                {
                    _perfect.PopUp();
                    _perfect.transform.Translate(Vector3.back);
                }
                break;
            default:
                break;
        }
    }
}
