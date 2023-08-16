using UnityEngine;

public class VelocityCalculator : MonoBehaviour
{
    [SerializeField] private Transform target;
    private Vector3 _lastPosition;
    private Vector3 _velocity;
    public Vector3 Velocity => _velocity;

    private void FixedUpdate()
    {
        _velocity = (target.position - _lastPosition) / Time.fixedDeltaTime;
        _lastPosition = target.position;
    }
}