using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using UnityEngine;

public class PokeRadiusSizeMatch : MonoBehaviour
{
    [SerializeField] private Transform _objectToMatch;
    [SerializeField] private PokeInteractor _pokeInteractor;

    private float _ratio = 1f;
    private float _prevScale;

    private void Start(){
        _prevScale = _objectToMatch.localScale.x;
        _ratio = _objectToMatch.localScale.x / _pokeInteractor.Radius;
    }
    
    //change this to an onResize event so we can get rid of prevScale.
    private void FixedUpdate(){
        if (_prevScale == _objectToMatch.localScale.x) return;
        
        _pokeInteractor.SetRadius(_objectToMatch.localScale.x / _ratio);
        _prevScale = _objectToMatch.localScale.x;
    }
}
