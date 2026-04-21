using UnityEngine;
using UnityEngine.InputSystem;

public class Pcont : MonoBehaviour
{

    public int maxHealt = 100;
    public int Health { get { return currentHealt; } }
    int currentHealt;
    public float speed = 3.0f;
    //public float invencibleT = 2.0f;
    //bool isinvencible;
    //float invencibletimer;

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

        currentHealt = maxHealt;

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

    public void ChangeHealt (int amount)
    {
        /*if (amount < 0)
        {
           // return;
            //isinvencible = true;
            //invencibletimer = invencibleT;
        }*/

        currentHealt = Mathf.Clamp(currentHealt + amount, 0, maxHealt);

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
    }
}