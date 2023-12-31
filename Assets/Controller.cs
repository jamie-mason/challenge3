//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Controller.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Controller: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controller"",
    ""maps"": [
        {
            ""name"": ""ActionMap"",
            ""id"": ""16fc4426-4f41-49a2-828c-7b7fbea4f9c7"",
            ""actions"": [
                {
                    ""name"": ""Dodge"",
                    ""type"": ""Button"",
                    ""id"": ""b9b3878f-81cc-40ba-80d8-027bfd663fd6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LightAttack"",
                    ""type"": ""Button"",
                    ""id"": ""662024e1-5616-4787-9e2e-69a2cdeabef0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HeavyAttack"",
                    ""type"": ""Button"",
                    ""id"": ""50fd37ca-f3ba-4991-a7cd-2d2d1f964c2a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Vault"",
                    ""type"": ""Button"",
                    ""id"": ""f78e91eb-d165-400e-aab7-6ccbc8f42328"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bc416755-1005-4e3c-b528-de9295073f6d"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""Dodge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d77b6f0c-2864-463c-9725-115628b599a6"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""LightAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07e72125-4b63-405c-9db5-8805b5a41c48"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeavyAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""061afefc-2864-43fa-89a6-e49c6eaca575"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""Vault"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Xbox Controller"",
            ""bindingGroup"": ""Xbox Controller"",
            ""devices"": []
        }
    ]
}");
        // ActionMap
        m_ActionMap = asset.FindActionMap("ActionMap", throwIfNotFound: true);
        m_ActionMap_Dodge = m_ActionMap.FindAction("Dodge", throwIfNotFound: true);
        m_ActionMap_LightAttack = m_ActionMap.FindAction("LightAttack", throwIfNotFound: true);
        m_ActionMap_HeavyAttack = m_ActionMap.FindAction("HeavyAttack", throwIfNotFound: true);
        m_ActionMap_Vault = m_ActionMap.FindAction("Vault", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // ActionMap
    private readonly InputActionMap m_ActionMap;
    private List<IActionMapActions> m_ActionMapActionsCallbackInterfaces = new List<IActionMapActions>();
    private readonly InputAction m_ActionMap_Dodge;
    private readonly InputAction m_ActionMap_LightAttack;
    private readonly InputAction m_ActionMap_HeavyAttack;
    private readonly InputAction m_ActionMap_Vault;
    public struct ActionMapActions
    {
        private @Controller m_Wrapper;
        public ActionMapActions(@Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @Dodge => m_Wrapper.m_ActionMap_Dodge;
        public InputAction @LightAttack => m_Wrapper.m_ActionMap_LightAttack;
        public InputAction @HeavyAttack => m_Wrapper.m_ActionMap_HeavyAttack;
        public InputAction @Vault => m_Wrapper.m_ActionMap_Vault;
        public InputActionMap Get() { return m_Wrapper.m_ActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionMapActions set) { return set.Get(); }
        public void AddCallbacks(IActionMapActions instance)
        {
            if (instance == null || m_Wrapper.m_ActionMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ActionMapActionsCallbackInterfaces.Add(instance);
            @Dodge.started += instance.OnDodge;
            @Dodge.performed += instance.OnDodge;
            @Dodge.canceled += instance.OnDodge;
            @LightAttack.started += instance.OnLightAttack;
            @LightAttack.performed += instance.OnLightAttack;
            @LightAttack.canceled += instance.OnLightAttack;
            @HeavyAttack.started += instance.OnHeavyAttack;
            @HeavyAttack.performed += instance.OnHeavyAttack;
            @HeavyAttack.canceled += instance.OnHeavyAttack;
            @Vault.started += instance.OnVault;
            @Vault.performed += instance.OnVault;
            @Vault.canceled += instance.OnVault;
        }

        private void UnregisterCallbacks(IActionMapActions instance)
        {
            @Dodge.started -= instance.OnDodge;
            @Dodge.performed -= instance.OnDodge;
            @Dodge.canceled -= instance.OnDodge;
            @LightAttack.started -= instance.OnLightAttack;
            @LightAttack.performed -= instance.OnLightAttack;
            @LightAttack.canceled -= instance.OnLightAttack;
            @HeavyAttack.started -= instance.OnHeavyAttack;
            @HeavyAttack.performed -= instance.OnHeavyAttack;
            @HeavyAttack.canceled -= instance.OnHeavyAttack;
            @Vault.started -= instance.OnVault;
            @Vault.performed -= instance.OnVault;
            @Vault.canceled -= instance.OnVault;
        }

        public void RemoveCallbacks(IActionMapActions instance)
        {
            if (m_Wrapper.m_ActionMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IActionMapActions instance)
        {
            foreach (var item in m_Wrapper.m_ActionMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ActionMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ActionMapActions @ActionMap => new ActionMapActions(this);
    private int m_XboxControllerSchemeIndex = -1;
    public InputControlScheme XboxControllerScheme
    {
        get
        {
            if (m_XboxControllerSchemeIndex == -1) m_XboxControllerSchemeIndex = asset.FindControlSchemeIndex("Xbox Controller");
            return asset.controlSchemes[m_XboxControllerSchemeIndex];
        }
    }
    public interface IActionMapActions
    {
        void OnDodge(InputAction.CallbackContext context);
        void OnLightAttack(InputAction.CallbackContext context);
        void OnHeavyAttack(InputAction.CallbackContext context);
        void OnVault(InputAction.CallbackContext context);
    }
}
