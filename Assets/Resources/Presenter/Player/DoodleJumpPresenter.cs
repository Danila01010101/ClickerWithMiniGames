using System;
using UnityEngine;

public class DoodleJumpPresenter : MonoBehaviour, ICoinCollector
{
    [SerializeField] private float _xMaxPosition;
    [SerializeField] private float _xMinPosition;
    [SerializeField] private float _jumpStreight;
    [SerializeField] private float _sideSpeed;
    [SerializeField] private float _zOffset;
    [SerializeField] private DoodleJumpCameraAndFallTriggerView _cameraView;

    private Rigidbody _playerRigidbody;
    private Vector3 _newPosition;
    private float _maxHeight;

    public Action<float> OnMaxHeightChange;

    private void Awake()
    {
        _playerRigidbody = GetComponent<Rigidbody>();
        _playerRigidbody.AddForce(Vector3.up * _jumpStreight);
    }

    private void Update()
    {
        transform.eulerAngles = Vector3.up * 180;
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (_playerRigidbody.velocity.y <= 0.1f && _playerRigidbody.velocity.y >= -0.1f)
                _playerRigidbody.AddForce(Vector3.up * _jumpStreight);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _newPosition += Vector3.right * _sideSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            _newPosition += Vector3.right * -_sideSpeed * Time.deltaTime;
        }

        _newPosition.x = Mathf.Clamp(_newPosition.x, _xMinPosition, _xMaxPosition);
        _newPosition.y = transform.position.y;
        _newPosition.z = _zOffset;

        if (_newPosition.y > _maxHeight)
        {
            _maxHeight = _newPosition.y;
            OnMaxHeightChange(_maxHeight);
        }

        transform.position = _newPosition;
    }

    private void OnEnable()
    {
        OnMaxHeightChange += _cameraView.LiftForCurrentPosition;
    }

    private void OnDisable()
    {
        OnMaxHeightChange -= _cameraView.LiftForCurrentPosition;
    }
}
