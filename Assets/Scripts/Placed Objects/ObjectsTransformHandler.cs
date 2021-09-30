using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.UI;

public class ObjectsTransformHandler : MonoBehaviour
{
    public bool IsRotated { get; set; }
    public bool IsScaled { get; set; }
    public bool IsDragged { get; set; }

    [SerializeField] private ObjectsTransformBase _scaleObject;
    [SerializeField] private ObjectsTransformBase _rotateObject;
    [SerializeField] private ObjectsTransformBase _dragObject;
    [SerializeField] private ModelOutline _outline;

    private void OnEnable()
    {
        TouchSimulation.Enable();
        _scaleObject.TransformEvent.AddListener(OnScale);
        _rotateObject.TransformEvent.AddListener(OnRotate);
        _dragObject.TransformEvent.AddListener(onDragging);
    }

    public void SelectObject()
    {
        _scaleObject.StartTouch();
        _rotateObject.StartTouch();
        _dragObject.StartTouch();
        _outline.enabled = true;
    }

    public void DeselectObject()
    {
        _scaleObject.StopTouch();
        _rotateObject.StopTouch();
        _dragObject.StopTouch();
        _outline.enabled = false;
    }

    private void HandleTransform()
    {
        _scaleObject.IsWorking = false;
        _dragObject.IsWorking = false;
        _rotateObject.IsWorking = false;

        if (IsScaled)
        {
            _scaleObject.IsWorking = true;
            return;
        }
        if (IsDragged)
        {
            _dragObject.IsWorking = true;
            return;
        }
        if (IsRotated)
        {
            _rotateObject.IsWorking = true;
            return;
        }
    }

    public void OnRotate(bool isRot)
    {
        IsRotated = isRot;
        HandleTransform();
    }

    public void OnScale(bool isScale)
    {
        IsScaled = isScale;
        HandleTransform();
    }

    public void onDragging(bool isDarg)
    {
        IsDragged = isDarg;
        HandleTransform();
    }
}