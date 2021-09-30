using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class DragObject : ObjectsTransformBase
{
    private Vector2 touchPosition = default;
    private Coroutine _coroutine;

    private void Start()
    {

        _touchControls.Drag.SecondaryTouchDetect.performed += StartDragGameObject;
        _touchControls.Drag.SecondaryTouchDetect.canceled += StartDragGameObject;
    }

    private void StartDragGameObject(InputAction.CallbackContext ctx)
    {
        var isPressed = ctx.ReadValueAsButton();

        if (isPressed)
            _coroutine = StartCoroutine(DragGameObject());
        else
        {
            StopAllCoroutines();
            PlaneHandler.instance.TouchHoldTap(false);
        }

        TransformEvent.Invoke(isPressed);
    }
    public override void StartTouch()
    {
        _touchControls.Drag.Enable();
    }
    public override void StopTouch()
    {
        _touchControls.Drag.Disable();
    }
    private IEnumerator DragGameObject()
    {
        while (true)
        {
            yield return null;
            if (!IsWorking) continue;
            PlaneHandler.instance.TouchHoldTap(true);
        }
    }
}