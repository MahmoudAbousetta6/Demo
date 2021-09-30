using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectsTransformBase : MonoBehaviour
{
    public bool IsWorking { get; set; }
    public UnityEvent<bool> TransformEvent;

    protected TouchControls _touchControls;

    private void Awake()
    {
        _touchControls = new TouchControls();
    }

    public virtual void StartTouch() => _touchControls.Enable();

    public virtual void StopTouch() => _touchControls.Disable();

    private void OnEnable()
    {
        StartTouch();
    }

    private void OnDisable()
    {
        StopTouch();
    }
}
