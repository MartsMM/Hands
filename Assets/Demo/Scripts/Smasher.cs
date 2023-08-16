using UnityEngine;

public class Smasher : MonoBehaviour
{
    [SerializeField] private VelocityCalculator _velocityCalculator;
    public Vector3 Velocity => _velocityCalculator.Velocity;
}

