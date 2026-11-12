using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private InputAction jumpAction;
    private InputAction moveAction;

    private void Start()
    {
        jumpAction = InputSystem.actions.FindAction("Jump");
        moveAction = InputSystem.actions.FindAction("Move");

    }

    private void Update()
    {
        if(jumpAction.triggered)
        {
            Debug.Log("ƒWƒƒƒ“ƒv‚µ‚½");
        }

        Vector2 moveInput = moveAction.ReadValue<Vector2>();
    }
}
