using UnityEngine;
using UnityEngine.InputSystem;

public class Pcont : MonoBehaviour
{
    [Header("Movimiento")]
    public float moveSpeed = 5f;
    Rigidbody2D rb;
    Vector2 moveInput;

    private InputSystem_Actions inputActions;

    InputAction moveAction;

    void Awake()
    {
        inputActions = new InputSystem_Actions();
        
        rb = GetComponent<Rigidbody2D>();

        moveAction = inputActions.Player.Move;
    }

    void OnEnable()
    {
        inputActions.Player.Enable();
    }

    void OnDisable()
    {
        inputActions.Player.Disable();
    }

    void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>().normalized;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
    }
}