// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/ControllerStuff.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControllerStuff : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @ControllerStuff()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControllerStuff"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""6ee0889b-f30e-44e2-8634-90c5f56cddf1"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""ccf776a6-f966-4641-80e5-73607f9ea07a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveCamera"",
                    ""type"": ""Button"",
                    ""id"": ""0c1818f1-de86-4d85-80a6-ec9e23aac63b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpeedBoostL"",
                    ""type"": ""Button"",
                    ""id"": ""3d3ddd3a-6a0d-4a37-9464-b82d43ac9cd5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpeedBoostR"",
                    ""type"": ""Button"",
                    ""id"": ""8113b538-c002-4bf5-8e0f-393ef9e94e9c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PickUP"",
                    ""type"": ""Button"",
                    ""id"": ""9adf6a4e-bb3a-463b-820f-8145b43aa5a8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Drop"",
                    ""type"": ""Button"",
                    ""id"": ""0ecb80db-266e-411d-a05b-b97a76e7a1f7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0af65425-722d-484c-9249-d666599919f6"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ea80e2c-78b1-4089-8f09-65232a15b818"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f599e58-9d8d-47f3-b2b2-f6f7b0c46013"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpeedBoostL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfabd94c-02b7-42da-af20-0e3383ea51e4"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpeedBoostR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""560aa526-bdff-46fb-b871-560bd3bd83fb"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickUP"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41c62360-f83a-46b7-93e2-89157e334ddd"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""5a3750f0-4679-44ea-9e2b-fa7a305d5c83"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""ef38494e-eeef-4325-ad0d-d800878ee777"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StartSotryboard"",
                    ""type"": ""Button"",
                    ""id"": ""4857baa0-5678-4381-974f-ef373cdcfcd5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c4b25eaf-294f-4747-9319-40113ec74ef0"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2d16cea-105e-42de-9b73-2dadefe37e16"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartSotryboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_MoveCamera = m_Gameplay.FindAction("MoveCamera", throwIfNotFound: true);
        m_Gameplay_SpeedBoostL = m_Gameplay.FindAction("SpeedBoostL", throwIfNotFound: true);
        m_Gameplay_SpeedBoostR = m_Gameplay.FindAction("SpeedBoostR", throwIfNotFound: true);
        m_Gameplay_PickUP = m_Gameplay.FindAction("PickUP", throwIfNotFound: true);
        m_Gameplay_Drop = m_Gameplay.FindAction("Drop", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Pause = m_Menu.FindAction("Pause", throwIfNotFound: true);
        m_Menu_StartSotryboard = m_Menu.FindAction("StartSotryboard", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_MoveCamera;
    private readonly InputAction m_Gameplay_SpeedBoostL;
    private readonly InputAction m_Gameplay_SpeedBoostR;
    private readonly InputAction m_Gameplay_PickUP;
    private readonly InputAction m_Gameplay_Drop;
    public struct GameplayActions
    {
        private @ControllerStuff m_Wrapper;
        public GameplayActions(@ControllerStuff wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @MoveCamera => m_Wrapper.m_Gameplay_MoveCamera;
        public InputAction @SpeedBoostL => m_Wrapper.m_Gameplay_SpeedBoostL;
        public InputAction @SpeedBoostR => m_Wrapper.m_Gameplay_SpeedBoostR;
        public InputAction @PickUP => m_Wrapper.m_Gameplay_PickUP;
        public InputAction @Drop => m_Wrapper.m_Gameplay_Drop;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @MoveCamera.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveCamera;
                @MoveCamera.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveCamera;
                @MoveCamera.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveCamera;
                @SpeedBoostL.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeedBoostL;
                @SpeedBoostL.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeedBoostL;
                @SpeedBoostL.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeedBoostL;
                @SpeedBoostR.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeedBoostR;
                @SpeedBoostR.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeedBoostR;
                @SpeedBoostR.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpeedBoostR;
                @PickUP.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPickUP;
                @PickUP.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPickUP;
                @PickUP.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPickUP;
                @Drop.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDrop;
                @Drop.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDrop;
                @Drop.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDrop;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @MoveCamera.started += instance.OnMoveCamera;
                @MoveCamera.performed += instance.OnMoveCamera;
                @MoveCamera.canceled += instance.OnMoveCamera;
                @SpeedBoostL.started += instance.OnSpeedBoostL;
                @SpeedBoostL.performed += instance.OnSpeedBoostL;
                @SpeedBoostL.canceled += instance.OnSpeedBoostL;
                @SpeedBoostR.started += instance.OnSpeedBoostR;
                @SpeedBoostR.performed += instance.OnSpeedBoostR;
                @SpeedBoostR.canceled += instance.OnSpeedBoostR;
                @PickUP.started += instance.OnPickUP;
                @PickUP.performed += instance.OnPickUP;
                @PickUP.canceled += instance.OnPickUP;
                @Drop.started += instance.OnDrop;
                @Drop.performed += instance.OnDrop;
                @Drop.canceled += instance.OnDrop;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Pause;
    private readonly InputAction m_Menu_StartSotryboard;
    public struct MenuActions
    {
        private @ControllerStuff m_Wrapper;
        public MenuActions(@ControllerStuff wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_Menu_Pause;
        public InputAction @StartSotryboard => m_Wrapper.m_Menu_StartSotryboard;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnPause;
                @StartSotryboard.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnStartSotryboard;
                @StartSotryboard.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnStartSotryboard;
                @StartSotryboard.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnStartSotryboard;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @StartSotryboard.started += instance.OnStartSotryboard;
                @StartSotryboard.performed += instance.OnStartSotryboard;
                @StartSotryboard.canceled += instance.OnStartSotryboard;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnMoveCamera(InputAction.CallbackContext context);
        void OnSpeedBoostL(InputAction.CallbackContext context);
        void OnSpeedBoostR(InputAction.CallbackContext context);
        void OnPickUP(InputAction.CallbackContext context);
        void OnDrop(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnPause(InputAction.CallbackContext context);
        void OnStartSotryboard(InputAction.CallbackContext context);
    }
}
