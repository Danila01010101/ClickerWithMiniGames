using UnityEngine;

public class DoodleJumpCameraView : MonoBehaviour
{
    [SerializeField] private Transform _cameraTransform;
    [SerializeField] private Vector3 _positionOffset;
    private Vector3 _currentPosition;

    private void Awake()
    {
        _currentPosition = transform.position - _positionOffset;
    }

    public void LiftForCurrentPosition(float newYPosition)
    {
        if (_currentPosition.y < newYPosition)
        {
            _currentPosition.y = newYPosition;
            _cameraTransform.position = _currentPosition + _positionOffset;
        }
    }
}