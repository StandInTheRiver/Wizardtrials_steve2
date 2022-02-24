// GENERATED AUTOMATICALLY FROM 'Assets/input_player_controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Input_player_controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input_player_controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""input_player_controls"",
    ""maps"": [
        {
            ""name"": ""gameplay"",
            ""id"": ""2b991a01-468b-4040-b3e4-cb951c5307b8"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""8d4260f0-e249-41e6-8b7a-39bbd815205c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""f18278fd-6f90-461c-81d4-75cc6068844d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""move left"",
                    ""type"": ""Button"",
                    ""id"": ""03315b2a-b76c-4b1c-990b-f97be4d14be7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""move right"",
                    ""type"": ""Button"",
                    ""id"": ""54f74962-598f-4463-b872-1bf63efb3e75"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""toggle run"",
                    ""type"": ""Button"",
                    ""id"": ""4dda70db-c4e4-419d-9241-2b0d49d000d3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""toggle special"",
                    ""type"": ""Button"",
                    ""id"": ""084141fc-982a-4be6-8be2-82c57fb80fad"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""pause"",
                    ""type"": ""Button"",
                    ""id"": ""f0a85c60-648f-40f6-9273-720a8ee27e7b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f81bf199-5d63-49be-92e7-b7fdd6cba913"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""064e3745-ba0a-4233-855d-be9bfce909ba"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48634fe7-7e57-4792-b874-935af66fd8b8"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6be4d033-54b2-4159-a511-f4de61765f5a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa87641b-4860-41d4-8895-7b9112112989"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ad206bf-2c23-497b-ac05-800726afc247"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9eceed66-6b1b-4a22-8ec7-ce87e54b904c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d52b6b2b-f69e-4837-b3ee-e51443176d4f"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1bca733-6769-4d00-a255-4d07a006c7f3"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ce7055b-6544-449c-830a-e1b93282e3c6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c5bec95-60db-41e0-8fd5-a533cf2a7d38"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""toggle run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67ad03d8-a807-4343-a4f1-dcc277ab0f8c"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""toggle run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30f9ce35-5d18-475d-9098-d37db16af8ec"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""toggle special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9929346-8d8c-48de-b991-f5744e6ae9c4"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""toggle special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f10282a-8e6a-47f7-bd26-b53c24b2646c"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7237cce-a39f-4dac-8d64-05a0b920c55d"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // gameplay
        m_gameplay = asset.FindActionMap("gameplay", throwIfNotFound: true);
        m_gameplay_Jump = m_gameplay.FindAction("Jump", throwIfNotFound: true);
        m_gameplay_Attack = m_gameplay.FindAction("Attack", throwIfNotFound: true);
        m_gameplay_moveleft = m_gameplay.FindAction("move left", throwIfNotFound: true);
        m_gameplay_moveright = m_gameplay.FindAction("move right", throwIfNotFound: true);
        m_gameplay_togglerun = m_gameplay.FindAction("toggle run", throwIfNotFound: true);
        m_gameplay_togglespecial = m_gameplay.FindAction("toggle special", throwIfNotFound: true);
        m_gameplay_pause = m_gameplay.FindAction("pause", throwIfNotFound: true);
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

    // gameplay
    private readonly InputActionMap m_gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_gameplay_Jump;
    private readonly InputAction m_gameplay_Attack;
    private readonly InputAction m_gameplay_moveleft;
    private readonly InputAction m_gameplay_moveright;
    private readonly InputAction m_gameplay_togglerun;
    private readonly InputAction m_gameplay_togglespecial;
    private readonly InputAction m_gameplay_pause;
    public struct GameplayActions
    {
        private @Input_player_controls m_Wrapper;
        public GameplayActions(@Input_player_controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_gameplay_Jump;
        public InputAction @Attack => m_Wrapper.m_gameplay_Attack;
        public InputAction @moveleft => m_Wrapper.m_gameplay_moveleft;
        public InputAction @moveright => m_Wrapper.m_gameplay_moveright;
        public InputAction @togglerun => m_Wrapper.m_gameplay_togglerun;
        public InputAction @togglespecial => m_Wrapper.m_gameplay_togglespecial;
        public InputAction @pause => m_Wrapper.m_gameplay_pause;
        public InputActionMap Get() { return m_Wrapper.m_gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Attack.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                @moveleft.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveleft;
                @moveleft.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveleft;
                @moveleft.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveleft;
                @moveright.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveright;
                @moveright.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveright;
                @moveright.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveright;
                @togglerun.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTogglerun;
                @togglerun.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTogglerun;
                @togglerun.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTogglerun;
                @togglespecial.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTogglespecial;
                @togglespecial.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTogglespecial;
                @togglespecial.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTogglespecial;
                @pause.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @pause.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                @pause.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @moveleft.started += instance.OnMoveleft;
                @moveleft.performed += instance.OnMoveleft;
                @moveleft.canceled += instance.OnMoveleft;
                @moveright.started += instance.OnMoveright;
                @moveright.performed += instance.OnMoveright;
                @moveright.canceled += instance.OnMoveright;
                @togglerun.started += instance.OnTogglerun;
                @togglerun.performed += instance.OnTogglerun;
                @togglerun.canceled += instance.OnTogglerun;
                @togglespecial.started += instance.OnTogglespecial;
                @togglespecial.performed += instance.OnTogglespecial;
                @togglespecial.canceled += instance.OnTogglespecial;
                @pause.started += instance.OnPause;
                @pause.performed += instance.OnPause;
                @pause.canceled += instance.OnPause;
            }
        }
    }
    public GameplayActions @gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnMoveleft(InputAction.CallbackContext context);
        void OnMoveright(InputAction.CallbackContext context);
        void OnTogglerun(InputAction.CallbackContext context);
        void OnTogglespecial(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
