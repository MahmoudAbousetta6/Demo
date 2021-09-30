// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Touch System/Touch Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TouchControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TouchControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Touch Controls"",
    ""maps"": [
        {
            ""name"": ""Rotate"",
            ""id"": ""1726b7cd-d12c-4cc9-bdf7-a1157e3bf6a7"",
            ""actions"": [
                {
                    ""name"": ""Primary Finger Position"",
                    ""type"": ""Value"",
                    ""id"": ""507746ad-1836-4dca-89a5-234209fe918a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary Touch Detect"",
                    ""type"": ""Value"",
                    ""id"": ""b1ec2e79-275e-4ee6-80d4-7227957d8c40"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6d23bdfe-63e5-4e65-b928-0d477a7ad5a8"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Finger Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1256b889-625e-42a0-b318-fbee5d5a5ea8"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary Touch Detect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""DoubleTap"",
            ""id"": ""a870f123-9dab-4b49-b582-d60796f43f6a"",
            ""actions"": [
                {
                    ""name"": ""Tap"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e40ac65d-bba0-4c1c-95a9-19d0766e8a43"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""MultiTap""
                },
                {
                    ""name"": ""Position"",
                    ""type"": ""Value"",
                    ""id"": ""bc638955-22b7-4d78-b355-73a1df0f4ff8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""76d9601d-185e-4d1d-a4fe-9428287602aa"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f59fcf81-c1d1-41e2-949f-dfc58fc9d233"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Scale"",
            ""id"": ""23784e3e-9e95-483f-ab70-1ecc61342a97"",
            ""actions"": [
                {
                    ""name"": ""Primary Finger Position"",
                    ""type"": ""Value"",
                    ""id"": ""b6ca9dba-f379-498f-9af9-afedc34813bd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary Finger Position"",
                    ""type"": ""Value"",
                    ""id"": ""3209471b-011d-4866-a3f9-35a395c4339d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary Touch Detect"",
                    ""type"": ""Button"",
                    ""id"": ""bb71f44a-b5e3-4a0e-b93a-8b24882b94ee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""74ab461e-9a6f-43f6-805a-8ed07522cfdb"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary Touch Detect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""523a9424-72bf-403f-8e9f-fc5476e43289"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary Finger Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09708404-3716-4b44-a5a1-0ecadf2bb7e8"",
                    ""path"": ""<Touchscreen>/touch0/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Finger Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Drag"",
            ""id"": ""b4d0501a-8390-4b58-bb06-4e20575cb3f3"",
            ""actions"": [
                {
                    ""name"": ""Primary Finger Position"",
                    ""type"": ""Value"",
                    ""id"": ""e948031f-012a-45c9-a05a-b80d014fd2c1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary Touch Detect"",
                    ""type"": ""Value"",
                    ""id"": ""2cf0585c-a0eb-43e4-87db-2a201705678f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=1,pressPoint=0.8),Press(behavior=1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5b63467f-2cc9-4302-b7da-213d9a7e4705"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Finger Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""def0fa40-f433-41c6-9e67-a90745067a30"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary Touch Detect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Rotate
        m_Rotate = asset.FindActionMap("Rotate", throwIfNotFound: true);
        m_Rotate_PrimaryFingerPosition = m_Rotate.FindAction("Primary Finger Position", throwIfNotFound: true);
        m_Rotate_SecondaryTouchDetect = m_Rotate.FindAction("Secondary Touch Detect", throwIfNotFound: true);
        // DoubleTap
        m_DoubleTap = asset.FindActionMap("DoubleTap", throwIfNotFound: true);
        m_DoubleTap_Tap = m_DoubleTap.FindAction("Tap", throwIfNotFound: true);
        m_DoubleTap_Position = m_DoubleTap.FindAction("Position", throwIfNotFound: true);
        // Scale
        m_Scale = asset.FindActionMap("Scale", throwIfNotFound: true);
        m_Scale_PrimaryFingerPosition = m_Scale.FindAction("Primary Finger Position", throwIfNotFound: true);
        m_Scale_SecondaryFingerPosition = m_Scale.FindAction("Secondary Finger Position", throwIfNotFound: true);
        m_Scale_SecondaryTouchDetect = m_Scale.FindAction("Secondary Touch Detect", throwIfNotFound: true);
        // Drag
        m_Drag = asset.FindActionMap("Drag", throwIfNotFound: true);
        m_Drag_PrimaryFingerPosition = m_Drag.FindAction("Primary Finger Position", throwIfNotFound: true);
        m_Drag_SecondaryTouchDetect = m_Drag.FindAction("Secondary Touch Detect", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Rotate
    private readonly InputActionMap m_Rotate;
    private IRotateActions m_RotateActionsCallbackInterface;
    private readonly InputAction m_Rotate_PrimaryFingerPosition;
    private readonly InputAction m_Rotate_SecondaryTouchDetect;
    public struct RotateActions
    {
        private @TouchControls m_Wrapper;
        public RotateActions(@TouchControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PrimaryFingerPosition => m_Wrapper.m_Rotate_PrimaryFingerPosition;
        public InputAction @SecondaryTouchDetect => m_Wrapper.m_Rotate_SecondaryTouchDetect;
        public InputActionMap Get() { return m_Wrapper.m_Rotate; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RotateActions set) { return set.Get(); }
        public void SetCallbacks(IRotateActions instance)
        {
            if (m_Wrapper.m_RotateActionsCallbackInterface != null)
            {
                @PrimaryFingerPosition.started -= m_Wrapper.m_RotateActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed -= m_Wrapper.m_RotateActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled -= m_Wrapper.m_RotateActionsCallbackInterface.OnPrimaryFingerPosition;
                @SecondaryTouchDetect.started -= m_Wrapper.m_RotateActionsCallbackInterface.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.performed -= m_Wrapper.m_RotateActionsCallbackInterface.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.canceled -= m_Wrapper.m_RotateActionsCallbackInterface.OnSecondaryTouchDetect;
            }
            m_Wrapper.m_RotateActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PrimaryFingerPosition.started += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled += instance.OnPrimaryFingerPosition;
                @SecondaryTouchDetect.started += instance.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.performed += instance.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.canceled += instance.OnSecondaryTouchDetect;
            }
        }
    }
    public RotateActions @Rotate => new RotateActions(this);

    // DoubleTap
    private readonly InputActionMap m_DoubleTap;
    private IDoubleTapActions m_DoubleTapActionsCallbackInterface;
    private readonly InputAction m_DoubleTap_Tap;
    private readonly InputAction m_DoubleTap_Position;
    public struct DoubleTapActions
    {
        private @TouchControls m_Wrapper;
        public DoubleTapActions(@TouchControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Tap => m_Wrapper.m_DoubleTap_Tap;
        public InputAction @Position => m_Wrapper.m_DoubleTap_Position;
        public InputActionMap Get() { return m_Wrapper.m_DoubleTap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DoubleTapActions set) { return set.Get(); }
        public void SetCallbacks(IDoubleTapActions instance)
        {
            if (m_Wrapper.m_DoubleTapActionsCallbackInterface != null)
            {
                @Tap.started -= m_Wrapper.m_DoubleTapActionsCallbackInterface.OnTap;
                @Tap.performed -= m_Wrapper.m_DoubleTapActionsCallbackInterface.OnTap;
                @Tap.canceled -= m_Wrapper.m_DoubleTapActionsCallbackInterface.OnTap;
                @Position.started -= m_Wrapper.m_DoubleTapActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_DoubleTapActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_DoubleTapActionsCallbackInterface.OnPosition;
            }
            m_Wrapper.m_DoubleTapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Tap.started += instance.OnTap;
                @Tap.performed += instance.OnTap;
                @Tap.canceled += instance.OnTap;
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
            }
        }
    }
    public DoubleTapActions @DoubleTap => new DoubleTapActions(this);

    // Scale
    private readonly InputActionMap m_Scale;
    private IScaleActions m_ScaleActionsCallbackInterface;
    private readonly InputAction m_Scale_PrimaryFingerPosition;
    private readonly InputAction m_Scale_SecondaryFingerPosition;
    private readonly InputAction m_Scale_SecondaryTouchDetect;
    public struct ScaleActions
    {
        private @TouchControls m_Wrapper;
        public ScaleActions(@TouchControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PrimaryFingerPosition => m_Wrapper.m_Scale_PrimaryFingerPosition;
        public InputAction @SecondaryFingerPosition => m_Wrapper.m_Scale_SecondaryFingerPosition;
        public InputAction @SecondaryTouchDetect => m_Wrapper.m_Scale_SecondaryTouchDetect;
        public InputActionMap Get() { return m_Wrapper.m_Scale; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ScaleActions set) { return set.Get(); }
        public void SetCallbacks(IScaleActions instance)
        {
            if (m_Wrapper.m_ScaleActionsCallbackInterface != null)
            {
                @PrimaryFingerPosition.started -= m_Wrapper.m_ScaleActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed -= m_Wrapper.m_ScaleActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled -= m_Wrapper.m_ScaleActionsCallbackInterface.OnPrimaryFingerPosition;
                @SecondaryFingerPosition.started -= m_Wrapper.m_ScaleActionsCallbackInterface.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.performed -= m_Wrapper.m_ScaleActionsCallbackInterface.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.canceled -= m_Wrapper.m_ScaleActionsCallbackInterface.OnSecondaryFingerPosition;
                @SecondaryTouchDetect.started -= m_Wrapper.m_ScaleActionsCallbackInterface.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.performed -= m_Wrapper.m_ScaleActionsCallbackInterface.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.canceled -= m_Wrapper.m_ScaleActionsCallbackInterface.OnSecondaryTouchDetect;
            }
            m_Wrapper.m_ScaleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PrimaryFingerPosition.started += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled += instance.OnPrimaryFingerPosition;
                @SecondaryFingerPosition.started += instance.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.performed += instance.OnSecondaryFingerPosition;
                @SecondaryFingerPosition.canceled += instance.OnSecondaryFingerPosition;
                @SecondaryTouchDetect.started += instance.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.performed += instance.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.canceled += instance.OnSecondaryTouchDetect;
            }
        }
    }
    public ScaleActions @Scale => new ScaleActions(this);

    // Drag
    private readonly InputActionMap m_Drag;
    private IDragActions m_DragActionsCallbackInterface;
    private readonly InputAction m_Drag_PrimaryFingerPosition;
    private readonly InputAction m_Drag_SecondaryTouchDetect;
    public struct DragActions
    {
        private @TouchControls m_Wrapper;
        public DragActions(@TouchControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PrimaryFingerPosition => m_Wrapper.m_Drag_PrimaryFingerPosition;
        public InputAction @SecondaryTouchDetect => m_Wrapper.m_Drag_SecondaryTouchDetect;
        public InputActionMap Get() { return m_Wrapper.m_Drag; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DragActions set) { return set.Get(); }
        public void SetCallbacks(IDragActions instance)
        {
            if (m_Wrapper.m_DragActionsCallbackInterface != null)
            {
                @PrimaryFingerPosition.started -= m_Wrapper.m_DragActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed -= m_Wrapper.m_DragActionsCallbackInterface.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled -= m_Wrapper.m_DragActionsCallbackInterface.OnPrimaryFingerPosition;
                @SecondaryTouchDetect.started -= m_Wrapper.m_DragActionsCallbackInterface.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.performed -= m_Wrapper.m_DragActionsCallbackInterface.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.canceled -= m_Wrapper.m_DragActionsCallbackInterface.OnSecondaryTouchDetect;
            }
            m_Wrapper.m_DragActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PrimaryFingerPosition.started += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.performed += instance.OnPrimaryFingerPosition;
                @PrimaryFingerPosition.canceled += instance.OnPrimaryFingerPosition;
                @SecondaryTouchDetect.started += instance.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.performed += instance.OnSecondaryTouchDetect;
                @SecondaryTouchDetect.canceled += instance.OnSecondaryTouchDetect;
            }
        }
    }
    public DragActions @Drag => new DragActions(this);
    public interface IRotateActions
    {
        void OnPrimaryFingerPosition(InputAction.CallbackContext context);
        void OnSecondaryTouchDetect(InputAction.CallbackContext context);
    }
    public interface IDoubleTapActions
    {
        void OnTap(InputAction.CallbackContext context);
        void OnPosition(InputAction.CallbackContext context);
    }
    public interface IScaleActions
    {
        void OnPrimaryFingerPosition(InputAction.CallbackContext context);
        void OnSecondaryFingerPosition(InputAction.CallbackContext context);
        void OnSecondaryTouchDetect(InputAction.CallbackContext context);
    }
    public interface IDragActions
    {
        void OnPrimaryFingerPosition(InputAction.CallbackContext context);
        void OnSecondaryTouchDetect(InputAction.CallbackContext context);
    }
}
