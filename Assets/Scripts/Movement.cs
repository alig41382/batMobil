using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField]
    float normalSpeed = 5f;

    [SerializeField]
    float boostSpeed = 10f;

    [SerializeField]
    float rotationSpeed = 180f;

    private float currentSpeed;
    private Rigidbody2D rb;
    private PlayerState playerState;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentSpeed = normalSpeed;
        playerState = GetComponent<PlayerState>();
    }

    void Update()
    {
        HandleSpeed();
        PlayerMovement();
    }

    /// <summary>
    /// Switch between normal and boost speed when holding Left Shift.
    /// </summary>
    private void HandleSpeed()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = boostSpeed;
        }
        else
        {
            currentSpeed = normalSpeed;
        }

        switch (playerState.GetBatmanState())
        {
            case BatmanStates.Normal:
                currentSpeed = normalSpeed;
                break;
            case BatmanStates.Stealth:
                currentSpeed = normalSpeed / 2f; // slower in stealth
                break;
            case BatmanStates.Alert:
                currentSpeed = boostSpeed; // faster in alert
                break;
        }
    }

    /// <summary>
    /// Movement (W/S) and rotation (A/D) for 2D top-down control.
    /// </summary>
    private void PlayerMovement()
    {
        float moveInput = Input.GetAxis("Vertical");
        float moveDirection = moveInput * currentSpeed * Time.deltaTime;

        float rotationInput = Input.GetAxis("Horizontal");
        float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -rotationAmount);
        transform.Translate(0, moveDirection, 0);
        // rb.velocity = moveDirection;
        // rb.rotation -= rotationAmount; //clockwise rotation
    }
}
