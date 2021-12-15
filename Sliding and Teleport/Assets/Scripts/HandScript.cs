using UnityEngine;
using UnityEngine.InputSystem;

public class HandScript : MonoBehaviour
{
    [SerializeField] InputActionReference controllerActionGrip;
    [SerializeField] InputActionReference controllerActionTrigger;

    private Animator _handAnimator;

    void Awake()
    {
        controllerActionGrip.action.performed += GripPress;
        controllerActionTrigger.action.performed += TriggerPress;

        _handAnimator = GetComponent<Animator>();
    }

    private void GripPress(InputAction.CallbackContext obj) => _handAnimator.SetFloat("Grip", obj.ReadValue<float>());
    private void TriggerPress(InputAction.CallbackContext obj) =>  _handAnimator.SetFloat("Trigger", obj.ReadValue<float>());
}
