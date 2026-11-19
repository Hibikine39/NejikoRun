using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private InputAction jumpAction;
    private InputAction moveAction;
    public Vector2 MoveKeyVector2 = Vector2.zero;

    private void Start()
    {
        jumpAction = InputSystem.actions.FindAction("Jump");
        moveAction = InputSystem.actions.FindAction("Move");

    }

    private void Update()
    {
        if (jumpAction.triggered)
        {
            Debug.Log("ƒWƒƒƒ“ƒv‚µ‚½");
        }

        MoveKeyVector2 = moveAction.ReadValue<Vector2>();
    }
}
