using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARRaycastManager))]

public class PlaneHandler : MonoBehaviour
{
    public static PlaneHandler instance;

    [SerializeField] private Camera _arCamera;
    public List<ObjectsTransformHandler> _ObjectsToPlace;

    protected TouchControls _touchControls;
    
    private ObjectsTransformHandler _objectTransformHandler;
    private ARRaycastManager _arRaycastManager;
    
    private int _objectsToPlaceIndex;
    private float _defaultRotation = 0;
    private bool _onTouchHold = false;

    private static List<ARRaycastHit> _hits = new List<ARRaycastHit>();
   
    void Awake()
    {
        instance ??= this;

        _touchControls = new TouchControls();
        _objectsToPlaceIndex = 0;
        _arRaycastManager = GetComponent<ARRaycastManager>();
    }

    private void OnEnable()
    {
        TouchSimulation.Enable();

        _touchControls.DoubleTap.Enable();
        _touchControls.DoubleTap.Tap.performed += OnTap;
    }

    private void OnDisable()
    {
        _touchControls.DoubleTap.Disable();
    }

    private void OnTap(InputAction.CallbackContext callbackContext)
    {
        Debug.LogError("ggggg");
        Vector2 _touchInput = _touchControls.DoubleTap.Position.ReadValue<Vector2>();
        Ray _ray = _arCamera.ScreenPointToRay(_touchInput);
        RaycastHit _hitObject;

        if (Physics.Raycast(_ray, out _hitObject))
        {
            _objectTransformHandler?.DeselectObject();
            _objectTransformHandler = _hitObject.transform.GetComponent<ObjectsTransformHandler>();
            _objectTransformHandler?.SelectObject();
           
        }
        if (_arRaycastManager.Raycast(_touchInput, _hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
        {
            Pose hitPose = _hits[0].pose;

            if (_objectTransformHandler == null)
            {
                if (_defaultRotation > 0)
                {
                    _objectTransformHandler = Instantiate(_ObjectsToPlace[_objectsToPlaceIndex], hitPose.position, Quaternion.identity);
                    _objectTransformHandler.transform.Rotate(Vector3.up, _defaultRotation);
                }
                else
                    _objectTransformHandler = Instantiate(_ObjectsToPlace[_objectsToPlaceIndex], hitPose.position, hitPose.rotation);

                _objectTransformHandler.DeselectObject();
            }
        }
        
    }

    public void SetObjectToPlaceIndex(int _index)
    {
        bool _validIndex = _index >= 0 && _index < _ObjectsToPlace.Count;
        _objectsToPlaceIndex = _validIndex ? _index : 0;
    }

    public void TouchHoldTap(bool _touchHold)
    {
        _onTouchHold = _touchHold;

        Vector2 _touchInput = _touchControls.DoubleTap.Position.ReadValue<Vector2>();
        if (_arRaycastManager.Raycast(_touchInput, _hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon))
        {
            Pose _hitPose = _hits[0].pose;
            if (_onTouchHold)
            {
                _objectTransformHandler.transform.position = _hitPose.position;
                if (_defaultRotation == 0)
                    _objectTransformHandler.transform.rotation = _hitPose.rotation;
            }
        }
    }
}