using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldExample : MonoBehaviour
{
    [SerializeField] private int _minRange;
    [SerializeField] private int _maxRange;

    private Vector3 _currentPosition;

    public Vector3 CurrentPosition => _currentPosition;

    private void OnValidate()
    {
        if (_minRange >= _maxRange)
            _minRange = _maxRange - 1;
    }
}
