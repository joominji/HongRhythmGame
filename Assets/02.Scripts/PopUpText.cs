using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Text))]
public class PopUpText : MonoBehaviour
{
    private TMP_Text _text;
    private Color _originColor;
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private Vector3 _direction = Vector3.up;
    [SerializeField] private float _moveSpeed = 0.5f;
    [SerializeField] private float _fadeSpeed = 0.5f;

    private void Awake()
    {
        _text = GetComponent<TMP_Text>();
        _originColor = _text.color;
    }

    private void Update()
    {
        transform.Translate(_direction * _moveSpeed * Time.deltaTime);

        float a = _text.color.a - _fadeSpeed * Time.deltaTime;
        if (a > 0.0f)
        {
            _text.color = new Color(_originColor.r, _originColor.g, _originColor.b, a);
        }
        else
        {
            gameObject.SetActive(false);
            _text.color = _originColor;
        }
    }

    public void PopUp()
    {
        ResetPosition();
        _text.color = _originColor;
        gameObject.SetActive(true);
    }

    public void PopUp(string text)
    {
        _text.text = text;
        PopUp();
    }

    public void ResetPosition()
    {
        transform.position = _startPosition;
    }
}
