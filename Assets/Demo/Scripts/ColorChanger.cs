using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Material material;
    [SerializeField] private Color _defaultColor = Color.white;
    [SerializeField] private Color _targetColor = Color.white;

    public void ChangeColor() => material.color = _targetColor;
    private void OnEnable() => material.color = _defaultColor;
    private void OnDisable() => material.color = _defaultColor; 

}
