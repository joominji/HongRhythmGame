using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NoteHitter : MonoBehaviour
{
    public enum HitRange
    {
        None,
        Bad,
        Miss,
        Good,
        Great,
        Perfect
    }
    [SerializeField] private KeyCode _key;
    [SerializeField] private LayerMask _hitMask;
    private SpriteRenderer _spriteRenderer;
    private Color _originColor;
    [SerializeField] private Color _pressedColor;
    [SerializeField] private GameObject _hitEffect;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _originColor = _spriteRenderer.color;
    }

    private void Update()
    {
        if (Input.GetKeyDown(_key))
        {
            Hit();
            _spriteRenderer.color = _pressedColor;
            _hitEffect.SetActive(true);
        }

        if(Input.GetKeyUp(_key))
        {
            _spriteRenderer.color = _originColor;
            _hitEffect.SetActive(false);
        }
    }

    private void Hit()
    {
        HitRange hitJudge = HitRange.Bad;

        Collider2D[] colnotes = Physics2D.OverlapBoxAll(point: transform.position,
                                                        size: new Vector2(transform.lossyScale.x / 2.0f,
                                                                           PlaySettings.HIT_JUDGE_RANGE_MISS),
                                                        angle: 0.0f,
                                                        layerMask: _hitMask);
        if (colnotes.Length > 0)
        {
            // 노트의 y 값에서 히터의 y값을 뺀 절대값이 제일 작은것이 제일 가까운 노트
            IOrderedEnumerable<Collider2D> colnotesFiltered = colnotes.OrderBy(x => Mathf.Abs(x.transform.position.y - transform.position.y));

            float distance = Mathf.Abs(colnotesFiltered.First().transform.position.y - transform.position.y);

            if(distance < PlaySettings.HIT_JUDGE_RANGE_PERFECT)
                hitJudge = HitRange.Perfect;
            else if(distance < PlaySettings.HIT_JUDGE_RANGE_GREAT)
                hitJudge = HitRange.Great;
            else if(distance < PlaySettings.HIT_JUDGE_RANGE_GOOD)
                hitJudge = HitRange.Good;
            else if(distance < PlaySettings.HIT_JUDGE_RANGE_MISS)
                hitJudge = HitRange.Miss;

            Destroy(colnotesFiltered.First().gameObject);
            HitAlertManager.instance.PopUp(hitJudge);
        }
    }

}
