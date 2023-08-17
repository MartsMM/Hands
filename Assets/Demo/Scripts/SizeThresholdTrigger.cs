using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SizeThresholdTrigger : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _targetSize = 5f;
    [SerializeField] private UnityEvent _onGreaterThan;

    private float _previousSize;

    private void Start()
    {
        _previousSize = _target.localScale.x;
    }

    private void Update()
    {
        var currentSize = _target.localScale.x;
        if(currentSize < _targetSize) return;   
        if (_previousSize >= _targetSize) return; // only trigger once when the size is greater than the threshold, can go back and force just not spam.
        
        _onGreaterThan.Invoke();
        _previousSize = _target.localScale.x;
    }
}
