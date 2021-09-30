using System.Collections;
using UnityEngine;

public class ScaleObject : ObjectsTransformBase
{
    [SerializeField] private Transform _objectToScale;
    private float _PinchInitialDistance;
    private Vector3 _objectInitialScale;
    private Coroutine _coroutine;

    private void Start()
    {
        _touchControls.Scale.SecondaryTouchDetect.started += _ => StartScaleGameObject();
        _touchControls.Scale.SecondaryTouchDetect.canceled += _ => EndScaleGameObject();
    }

    private void StartScaleGameObject()
    {
        _coroutine = StartCoroutine(ScaleGameObject());
        TransformEvent.Invoke(true);
    }

    private void EndScaleGameObject()
    {
        StopCoroutine(_coroutine);
        TransformEvent.Invoke(false);
    }
    public override void StartTouch()
    {
        _touchControls.Scale.Enable();
    }
    public override void StopTouch()
    {
        _touchControls.Scale.Disable();
    }
    private IEnumerator ScaleGameObject()
    {
        _PinchInitialDistance = Vector2.Distance(_touchControls.Scale.PrimaryFingerPosition.ReadValue<Vector2>(), _touchControls.Scale.SecondaryFingerPosition.ReadValue<Vector2>());
        _objectInitialScale = _objectToScale.localScale;

        while (true)
        {
            yield return null;
            if (!IsWorking) continue;
            float _pinchCurrentDistance = Vector2.Distance(_touchControls.Scale.PrimaryFingerPosition.ReadValue<Vector2>(), _touchControls.Scale.SecondaryFingerPosition.ReadValue<Vector2>());
            float _scaleFactor = _pinchCurrentDistance / _PinchInitialDistance;
            _objectToScale.localScale = (_objectInitialScale * _scaleFactor);
        }
    }
}