// GENERATED AUTOMATICALLY FROM 'Assets/M_PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @M_PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @M_PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""M_PlayerInput"",
    ""maps"": [
        {
            ""name"": ""playerOneInput"",
            ""id"": ""4198cc59-529f-4088-8c6f-fea596c69071"",
            ""actions"": [
                {
                    ""name"": ""WASD"",
                    ""type"": ""PassThrough"",
                    ""id"": ""368b1e1b-e719-4113-960f-22d820c199fb"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Enter"",
                    ""type"": ""Button"",
                    ""id"": ""85c0b0bb-76e0-4705-9bc6-946b8e1d7330"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Skill"",
                    ""type"": ""Button"",
                    ""id"": ""62caf2f5-41f8-47ee-8f88-a68754e4166a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""80bcfb08-b28f-4daf-bcf5-069a2c412fa9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d2d552b7-5002-4b1c-9e0d-4e344830622d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""75f32abd-d30b-4d63-9830-dae223339b46"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9d9da090-9643-4c09-8b68-882a69e8c83c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""dfd955c9-05a4-4a75-8d90-ca3095135251"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""dcef509f-3fd3-47bf-9722-2f3f50e50384"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3159ff07-5e8a-4455-ad43-bdb78bb9e143"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2fb57677-fa1d-4834-9f36-3a45f75d1124"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e37362be-c221-4971-a1e4-38fab6a683bf"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a107f46f-d6e7-4c13-b45e-d0785540d1b0"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""WASD"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0b22ff7a-1371-47a8-ba19-8ff12d833c60"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1271a124-c3d1-4e12-9770-33803dbe276f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df923ec1-3017-45a8-9b58-04ea7e583ff1"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34eeb07d-5ea5-4a65-9364-11ee5df64403"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // playerOneInput
        m_playerOneInput = asset.FindActionMap("playerOneInput", throwIfNotFound: true);
        m_playerOneInput_WASD = m_playerOneInput.FindAction("WASD", throwIfNotFound: true);
        m_playerOneInput_Enter = m_playerOneInput.FindAction("Enter", throwIfNotFound: true);
        m_playerOneInput_Skill = m_playerOneInput.FindAction("Skill", throwIfNotFound: true);
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

    // playerOneInput
    private readonly InputActionMap m_playerOneInput;
    private IPlayerOneInputActions m_PlayerOneInputActionsCallbackInterface;
    private readonly InputAction m_playerOneInput_WASD;
    private readonly InputAction m_playerOneInput_Enter;
    private readonly InputAction m_playerOneInput_Skill;
    public struct PlayerOneInputActions
    {
        private @M_PlayerInput m_Wrapper;
        public PlayerOneInputActions(@M_PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @WASD => m_Wrapper.m_playerOneInput_WASD;
        public InputAction @Enter => m_Wrapper.m_playerOneInput_Enter;
        public InputAction @Skill => m_Wrapper.m_playerOneInput_Skill;
        public InputActionMap Get() { return m_Wrapper.m_playerOneInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerOneInputActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerOneInputActions instance)
        {
            if (m_Wrapper.m_PlayerOneInputActionsCallbackInterface != null)
            {
                @WASD.started -= m_Wrapper.m_PlayerOneInputActionsCallbackInterface.OnWASD;
                @WASD.performed -= m_Wrapper.m_PlayerOneInputActionsCallbackInterface.OnWASD;
                @WASD.canceled -= m_Wrapper.m_PlayerOneInputActionsCallbackInterface.OnWASD;
                @Enter.started -= m_Wrapper.m_PlayerOneInputActionsCallbackInterface.OnEnter;
                @Enter.performed -= m_Wrapper.m_PlayerOneInputActionsCallbackInterface.OnEnter;
                @Enter.canceled -= m_Wrapper.m_PlayerOneInputActionsCallbackInterface.OnEnter;
                @Skill.started -= m_Wrapper.m_PlayerOneInputActionsCallbackInterface.OnSkill;
                @Skill.performed -= m_Wrapper.m_PlayerOneInputActionsCallbackInterface.OnSkill;
                @Skill.canceled -= m_Wrapper.m_PlayerOneInputActionsCallbackInterface.OnSkill;
            }
            m_Wrapper.m_PlayerOneInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @WASD.started += instance.OnWASD;
                @WASD.performed += instance.OnWASD;
                @WASD.canceled += instance.OnWASD;
                @Enter.started += instance.OnEnter;
                @Enter.performed += instance.OnEnter;
                @Enter.canceled += instance.OnEnter;
                @Skill.started += instance.OnSkill;
                @Skill.performed += instance.OnSkill;
                @Skill.canceled += instance.OnSkill;
            }
        }
    }
    public PlayerOneInputActions @playerOneInput => new PlayerOneInputActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerOneInputActions
    {
        void OnWASD(InputAction.CallbackContext context);
        void OnEnter(InputAction.CallbackContext context);
        void OnSkill(InputAction.CallbackContext context);
    }
}
