using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField]
    float normalSpeed = 5f;

    [SerializeField]
    float boostSpeed = 10f;

    // [SerializeField]
    // float rotationSpeed = 180f; //it was supposed to be rotation but now i understand its not rotation but another translate

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
        switch (playerState.GetBatmanState())
        {
            case PlayerState.BatmanStates.Normal:
                currentSpeed = normalSpeed;
                break;
            case PlayerState.BatmanStates.Stealth:
                currentSpeed = normalSpeed / 2f; // slower in stealth
                break;
            case PlayerState.BatmanStates.Alert:
                currentSpeed = boostSpeed; // faster in alert
                break;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = boostSpeed;
        }

        // else
        // {
        //     currentSpeed = normalSpeed;
        // }
    }

    /// <summary>
    /// Moves and rotates the player based on input.
    /// W/S -> Forward/backward
    /// A/D -> Rotate left/right
    /// </summary>
    private void PlayerMovement()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        // float moveInput = Input.GetAxis("Vertical");
        // float moveDirection = moveInput * currentSpeed * Time.deltaTime;
        // float rotationInput = Input.GetAxis("Horizontal");
        // float rotationAmount = rotationInput * currentSpeed * Time.deltaTime;

        // Face left or right
        if (horizontalInput < 0)
            transform.localScale = new Vector3(-2, 2, 1);
        else if (horizontalInput > 0)
            transform.localScale = new Vector3(2, 2, 1);

        float facing = transform.localScale.x;
        float moveX = forwardInput * facing * currentSpeed * Time.deltaTime;
        Vector3 futurePositon = new Vector3(transform.position.x + moveX, 0f, 0f);
        if (Mathf.Abs(futurePositon.x) > 8)
        {
            return;
        }
        transform.Translate(moveX, 0, 0);

        // transform.Translate(0, moveDirection, 0);
        // transform.Rotate(0, 0, -rotationAmount);
    }
}
