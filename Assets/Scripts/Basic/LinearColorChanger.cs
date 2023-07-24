using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearColorChanger : MonoBehaviour
{
    [HideInInspector] public SpriteRenderer Render;
    [SerializeField] private float _duration;

    [SerializeField] private Color _targetColor;
    private float _runningTime;
    private Color _startColor;

    // Start is called before the first frame update
    void Start()
    {
        Render = GetComponent<SpriteRenderer>();
        _startColor = Render.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (_runningTime <= _duration)
        {
            _runningTime += Time.deltaTime;
            float normalizeRunningTime = _runningTime / _duration;

            Color newColor = new Color(_targetColor.r * normalizeRunningTime, _targetColor.g * normalizeRunningTime, _targetColor.b * normalizeRunningTime);

            Render.color = Color.Lerp(_startColor, _targetColor, normalizeRunningTime);
        }
    }
}
