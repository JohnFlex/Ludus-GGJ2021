// GENERATED AUTOMATICALLY FROM 'Assets/Input System/MainControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MainControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainControls"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""e1b1a72b-db70-4a71-b619-49efb03d8bdd"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""25f7bcf2-4768-4a30-9b42-b725761aaa25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""109c5732-58f1-4cd2-a24a-751419ae0601"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Glide"",
                    ""type"": ""Button"",
                    ""id"": ""962398e7-d376-4cdc-bd77-757584cdae9e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Change World"",
                    ""type"": ""Button"",
                    ""id"": ""1f8b5433-14eb-43e5-9fd1-07643b2e4584"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ActivateItem"",
                    ""type"": ""Button"",
                    ""id"": ""ef018fab-35db-4a52-90bd-355a9fbd8328"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""74cf2aca-23bc-4fa7-9f80-1d454ffcf721"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3d3aef71-a8ec-46f1-bc58-a75d580a7bfe"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ClavierSouris"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""431ce9e4-3bbc-4fb0-8ed9-72de2c4bae50"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ClavierSouris"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Manette"",
                    ""id"": ""a5b682ed-2c2e-41fd-82a5-2340fec00d52"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""530ca794-f1ca-4fea-b205-00c7d30811b0"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Manette"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""78c4a20f-1bab-4ed7-8e5f-4d1f7fbe601a"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Manette"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""28d4bd74-ad2f-4134-84ec-64d72b7aabdc"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ClavierSouris"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3fae057-ca61-49b0-9191-ba6eeee640f4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Manette"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9969c1cc-affe-4ea7-915f-796bb5ee9594"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ClavierSouris"",
                    ""action"": ""Glide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2c8b669-a7e7-40ab-88cd-cb80a7468b00"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Manette"",
                    ""action"": ""Glide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36459ce1-9c30-4a81-aca8-35bc9750fd34"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ClavierSouris"",
                    ""action"": ""Change World"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d202267-06d3-4b38-bbd7-57b1e3d47212"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Manette"",
                    ""action"": ""Change World"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fd14b62-93b6-498d-8c54-913c4f28eeab"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ClavierSouris"",
                    ""action"": ""ActivateItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GhostMode"",
            ""id"": ""0d6b0e8b-46d5-49d1-a977-4ecb4deb8f0d"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""a3802290-7672-4de6-ac64-0ca68040d952"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""3fd6007e-8cd7-4b8b-8467-afa628d8d536"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9a849b66-2ba5-48ed-86f2-6991e924d570"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""43539204-67ab-4e5d-9da1-9554a770b00a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ClavierSouris"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""abaff0f5-6e25-4e2b-bd73-6c7e016d05ae"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4039231e-0f32-473d-8273-5fec013ca440"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8b0d1276-0fd8-4e31-b31f-0039f58f85b0"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""ClavierSouris"",
            ""bindingGroup"": ""ClavierSouris"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Manette"",
            ""bindingGroup"": ""Manette"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_Move = m_Default.FindAction("Move", throwIfNotFound: true);
        m_Default_Jump = m_Default.FindAction("Jump", throwIfNotFound: true);
        m_Default_Glide = m_Default.FindAction("Glide", throwIfNotFound: true);
        m_Default_ChangeWorld = m_Default.FindAction("Change World", throwIfNotFound: true);
        m_Default_ActivateItem = m_Default.FindAction("ActivateItem", throwIfNotFound: true);
        // GhostMode
        m_GhostMode = asset.FindActionMap("GhostMode", throwIfNotFound: true);
        m_GhostMode_Movement = m_GhostMode.FindAction("Movement", throwIfNotFound: true);
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

    // Default
    private readonly InputActionMap m_Default;
    private IDefaultActions m_DefaultActionsCallbackInterface;
    private readonly InputAction m_Default_Move;
    private readonly InputAction m_Default_Jump;
    private readonly InputAction m_Default_Glide;
    private readonly InputAction m_Default_ChangeWorld;
    private readonly InputAction m_Default_ActivateItem;
    public struct DefaultActions
    {
        private @MainControls m_Wrapper;
        public DefaultActions(@MainControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Default_Move;
        public InputAction @Jump => m_Wrapper.m_Default_Jump;
        public InputAction @Glide => m_Wrapper.m_Default_Glide;
        public InputAction @ChangeWorld => m_Wrapper.m_Default_ChangeWorld;
        public InputAction @ActivateItem => m_Wrapper.m_Default_ActivateItem;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnJump;
                @Glide.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnGlide;
                @Glide.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnGlide;
                @Glide.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnGlide;
                @ChangeWorld.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnChangeWorld;
                @ChangeWorld.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnChangeWorld;
                @ChangeWorld.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnChangeWorld;
                @ActivateItem.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnActivateItem;
                @ActivateItem.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnActivateItem;
                @ActivateItem.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnActivateItem;
            }
            m_Wrapper.m_DefaultActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Glide.started += instance.OnGlide;
                @Glide.performed += instance.OnGlide;
                @Glide.canceled += instance.OnGlide;
                @ChangeWorld.started += instance.OnChangeWorld;
                @ChangeWorld.performed += instance.OnChangeWorld;
                @ChangeWorld.canceled += instance.OnChangeWorld;
                @ActivateItem.started += instance.OnActivateItem;
                @ActivateItem.performed += instance.OnActivateItem;
                @ActivateItem.canceled += instance.OnActivateItem;
            }
        }
    }
    public DefaultActions @Default => new DefaultActions(this);

    // GhostMode
    private readonly InputActionMap m_GhostMode;
    private IGhostModeActions m_GhostModeActionsCallbackInterface;
    private readonly InputAction m_GhostMode_Movement;
    public struct GhostModeActions
    {
        private @MainControls m_Wrapper;
        public GhostModeActions(@MainControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_GhostMode_Movement;
        public InputActionMap Get() { return m_Wrapper.m_GhostMode; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GhostModeActions set) { return set.Get(); }
        public void SetCallbacks(IGhostModeActions instance)
        {
            if (m_Wrapper.m_GhostModeActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_GhostModeActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GhostModeActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GhostModeActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_GhostModeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public GhostModeActions @GhostMode => new GhostModeActions(this);
    private int m_ClavierSourisSchemeIndex = -1;
    public InputControlScheme ClavierSourisScheme
    {
        get
        {
            if (m_ClavierSourisSchemeIndex == -1) m_ClavierSourisSchemeIndex = asset.FindControlSchemeIndex("ClavierSouris");
            return asset.controlSchemes[m_ClavierSourisSchemeIndex];
        }
    }
    private int m_ManetteSchemeIndex = -1;
    public InputControlScheme ManetteScheme
    {
        get
        {
            if (m_ManetteSchemeIndex == -1) m_ManetteSchemeIndex = asset.FindControlSchemeIndex("Manette");
            return asset.controlSchemes[m_ManetteSchemeIndex];
        }
    }
    public interface IDefaultActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnGlide(InputAction.CallbackContext context);
        void OnChangeWorld(InputAction.CallbackContext context);
        void OnActivateItem(InputAction.CallbackContext context);
    }
    public interface IGhostModeActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
