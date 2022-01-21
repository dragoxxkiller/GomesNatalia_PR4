// GENERATED AUTOMATICALLY FROM 'Assets/Input_sistem/Input_Controler.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Input_Controler : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input_Controler()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input_Controler"",
    ""maps"": [
        {
            ""name"": ""Moverse"",
            ""id"": ""af4922a3-e065-4ffd-abe6-6c003dd9dd3b"",
            ""actions"": [
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""cd662a67-ccba-41e6-9a8d-fcdc63c11a3c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""ddfdc4e3-a9eb-433f-83a6-ca0d7c67889b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StraffeL"",
                    ""type"": ""Value"",
                    ""id"": ""0642483c-6094-4532-b1cf-7657dcbee9b4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StraffeR"",
                    ""type"": ""Value"",
                    ""id"": ""fb3a5b8e-a3d9-4c4d-9d0a-d36309b6167b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""62207814-93fa-40ed-9d89-ed43e4cb4b09"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6dc1e92c-b434-412f-91aa-54541153b780"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0042e3fd-fef1-4049-9feb-fdedaf45ccfe"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc0bb89d-6da4-41f0-bd33-67ed2893ce40"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7c53d634-7619-4af6-8c60-b209885f4a61"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""99d73c71-1a6d-430d-8912-23030864cefd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4ec6efda-399c-46b4-a8b9-08f6e2391c7f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d606f4db-7f65-4980-a815-83ef9948b3bb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""88a343b5-ccc5-45ce-9005-dd2f04cc5274"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0105498c-73d1-4169-86bc-5bb70555692f"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StraffeL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48573328-afcb-4233-93e0-56eed4b4e303"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StraffeR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c026d600-25dc-4669-9e60-f5d27bad4192"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camara"",
            ""id"": ""731ff696-cb01-41f6-8414-9b7ec95b38c7"",
            ""actions"": [
                {
                    ""name"": ""Pivotar"",
                    ""type"": ""Value"",
                    ""id"": ""5c5db606-9c85-4c89-b018-f8cd350f4070"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9fcf99f6-fc95-441c-9df2-9eb6c9b46575"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pivotar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Moverse
        m_Moverse = asset.FindActionMap("Moverse", throwIfNotFound: true);
        m_Moverse_Run = m_Moverse.FindAction("Run", throwIfNotFound: true);
        m_Moverse_Walk = m_Moverse.FindAction("Walk", throwIfNotFound: true);
        m_Moverse_StraffeL = m_Moverse.FindAction("StraffeL", throwIfNotFound: true);
        m_Moverse_StraffeR = m_Moverse.FindAction("StraffeR", throwIfNotFound: true);
        m_Moverse_Aim = m_Moverse.FindAction("Aim", throwIfNotFound: true);
        // Camara
        m_Camara = asset.FindActionMap("Camara", throwIfNotFound: true);
        m_Camara_Pivotar = m_Camara.FindAction("Pivotar", throwIfNotFound: true);
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

    // Moverse
    private readonly InputActionMap m_Moverse;
    private IMoverseActions m_MoverseActionsCallbackInterface;
    private readonly InputAction m_Moverse_Run;
    private readonly InputAction m_Moverse_Walk;
    private readonly InputAction m_Moverse_StraffeL;
    private readonly InputAction m_Moverse_StraffeR;
    private readonly InputAction m_Moverse_Aim;
    public struct MoverseActions
    {
        private @Input_Controler m_Wrapper;
        public MoverseActions(@Input_Controler wrapper) { m_Wrapper = wrapper; }
        public InputAction @Run => m_Wrapper.m_Moverse_Run;
        public InputAction @Walk => m_Wrapper.m_Moverse_Walk;
        public InputAction @StraffeL => m_Wrapper.m_Moverse_StraffeL;
        public InputAction @StraffeR => m_Wrapper.m_Moverse_StraffeR;
        public InputAction @Aim => m_Wrapper.m_Moverse_Aim;
        public InputActionMap Get() { return m_Wrapper.m_Moverse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoverseActions set) { return set.Get(); }
        public void SetCallbacks(IMoverseActions instance)
        {
            if (m_Wrapper.m_MoverseActionsCallbackInterface != null)
            {
                @Run.started -= m_Wrapper.m_MoverseActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_MoverseActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_MoverseActionsCallbackInterface.OnRun;
                @Walk.started -= m_Wrapper.m_MoverseActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_MoverseActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_MoverseActionsCallbackInterface.OnWalk;
                @StraffeL.started -= m_Wrapper.m_MoverseActionsCallbackInterface.OnStraffeL;
                @StraffeL.performed -= m_Wrapper.m_MoverseActionsCallbackInterface.OnStraffeL;
                @StraffeL.canceled -= m_Wrapper.m_MoverseActionsCallbackInterface.OnStraffeL;
                @StraffeR.started -= m_Wrapper.m_MoverseActionsCallbackInterface.OnStraffeR;
                @StraffeR.performed -= m_Wrapper.m_MoverseActionsCallbackInterface.OnStraffeR;
                @StraffeR.canceled -= m_Wrapper.m_MoverseActionsCallbackInterface.OnStraffeR;
                @Aim.started -= m_Wrapper.m_MoverseActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_MoverseActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_MoverseActionsCallbackInterface.OnAim;
            }
            m_Wrapper.m_MoverseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @StraffeL.started += instance.OnStraffeL;
                @StraffeL.performed += instance.OnStraffeL;
                @StraffeL.canceled += instance.OnStraffeL;
                @StraffeR.started += instance.OnStraffeR;
                @StraffeR.performed += instance.OnStraffeR;
                @StraffeR.canceled += instance.OnStraffeR;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
            }
        }
    }
    public MoverseActions @Moverse => new MoverseActions(this);

    // Camara
    private readonly InputActionMap m_Camara;
    private ICamaraActions m_CamaraActionsCallbackInterface;
    private readonly InputAction m_Camara_Pivotar;
    public struct CamaraActions
    {
        private @Input_Controler m_Wrapper;
        public CamaraActions(@Input_Controler wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pivotar => m_Wrapper.m_Camara_Pivotar;
        public InputActionMap Get() { return m_Wrapper.m_Camara; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CamaraActions set) { return set.Get(); }
        public void SetCallbacks(ICamaraActions instance)
        {
            if (m_Wrapper.m_CamaraActionsCallbackInterface != null)
            {
                @Pivotar.started -= m_Wrapper.m_CamaraActionsCallbackInterface.OnPivotar;
                @Pivotar.performed -= m_Wrapper.m_CamaraActionsCallbackInterface.OnPivotar;
                @Pivotar.canceled -= m_Wrapper.m_CamaraActionsCallbackInterface.OnPivotar;
            }
            m_Wrapper.m_CamaraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pivotar.started += instance.OnPivotar;
                @Pivotar.performed += instance.OnPivotar;
                @Pivotar.canceled += instance.OnPivotar;
            }
        }
    }
    public CamaraActions @Camara => new CamaraActions(this);
    public interface IMoverseActions
    {
        void OnRun(InputAction.CallbackContext context);
        void OnWalk(InputAction.CallbackContext context);
        void OnStraffeL(InputAction.CallbackContext context);
        void OnStraffeR(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
    }
    public interface ICamaraActions
    {
        void OnPivotar(InputAction.CallbackContext context);
    }
}
