using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using UnityEngine;

public class PokeRadiusSizeMatch : MonoBehaviour
{
    [SerializeField] private Transform _objectToMatch;
    [SerializeField] private PokeInteractor _pokeInteractor;

    private float _ratio = 1f;

    private void Start(){
        _ratio = _objectToMatch.localScale.x / _pokeInteractor.Radius;
    }

    private void FixedUpdate(){
        _pokeInteractor.SetRadius(_objectToMatch.localScale.x / _ratio);
    }
}
