using UnityEngine;

public class DoodleJumpCameraAndFallTriggerView : MonoBehaviour
{
    [SerializeField] private Transform _cameraTransform;
    [SerializeField] private Transform _endGameTriggerTransform;
    [SerializeField] private Vector3 _endGameTriggerPositionOffset;
    [SerializeField] private Vector3 _positionOffset;

    private Vector3 _currentPosition;

    private void Awake()
    {
        _currentPosition = transform.position;
        _cameraTransform.position = _currentPosition + _positionOffset;
    }

    public void LiftForCurrentPosition(float newYPosition)
    {
        if (_currentPosition.y < newYPosition)
        {
            _currentPosition.y = newYPosition;
            _endGameTriggerTransform.position = _endGameTriggerPositionOffset + _currentPosition;
            _cameraTransform.position = _currentPosition + _positionOffset;
        }
    }
}