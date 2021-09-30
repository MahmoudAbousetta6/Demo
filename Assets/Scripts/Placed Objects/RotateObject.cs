using System.Collections;
using UnityEngine;

public class RotateObject : ObjectsTransformBase
{
    [SerializeField] private Transform _objectToRotate;
    [SerializeField] private float rotationSpeed = 0.8f;

    private Coroutine _coroutine;
    private Vector2 _rotationDirection;

    private void Start()
    {
        _touchControls.Rotate.SecondaryTouchDetect.started += _ => StartRotateGameObject();
        _touchControls.Rotate.SecondaryTouchDetect.canceled += _ => EndRotateGameObject();
    }

    private void StartRotateGameObject()
    {
        _coroutine = StartCoroutine(RotateGameObject());
        TransformEvent.Invoke(true);
    }

    private void EndRotateGameObject()
    {
        StopCoroutine(_coroutine);
        _rotationDirection = Vector2.zero;
        TransformEvent.Invoke(false);
    }
    public override void StartTouch()
    {
        _touchControls.Rotate.Enable();
    }
    public override void StopTouch()
    {
        _touchControls.Rotate.Disable();
    }
    private IEnumerator RotateGameObject()
    {
        _rotationDirection.x = 0;
        _rotationDirection = _touchControls.Rotate.PrimaryFingerPosition.ReadValue<Vector2>();

        while (true)
        {
            yield return null;
            if (!IsWorking) continue;
            _rotationDirection.y = 0;
            var _temoRotationDirection = _touchControls.Rotate.PrimaryFingerPosition.ReadValue<Vector2>();

            if ((_temoRotationDirection.x - _rotationDirection.x) >= 0.1f)
                _objectToRotate.Rotate(-Vector3.up * _rotationDirection.x * rotationSpeed * Time.deltaTime);
            else if ((_temoRotationDirection.x - _rotationDirection.x) <= -0.1)
                _objectToRotate.Rotate(Vector3.up * _rotationDirection.x * rotationSpeed * Time.deltaTime);

            _rotationDirection = _temoRotationDirection;
        }
    }
}