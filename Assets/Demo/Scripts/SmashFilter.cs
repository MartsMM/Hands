using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using UnityEngine;

public class SmashFilter : MonoBehaviour, IGameObjectFilter
{
    [SerializeField] private float _smashVelocity = 5f;
    public  bool Filter(GameObject gameObject)
    {
        Smasher smasher = gameObject.GetComponent<Smasher>();
        if (smasher == null) return false;
        if (smasher.Velocity.magnitude < _smashVelocity) return false;

        return true;
    }
}
