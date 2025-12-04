using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] float normalSpeed = 5f;
    [SerializeField] float boostSpeed = 10f;
    [SerializeField] float rotationSpeed = 180f;

    private float currentSpeed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentSpeed = normalSpeed;
    }

    void Update()
    {   
        HandleSpeed();
        PlayerMovement();
    }

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
    }
    private void PlayerMovement()
    {
        float moveInput = Input.GetAxis("Vertical");
        Vector2 moveDirection = moveInput * currentSpeed * Time.deltaTime;

        float rotationInput = Input.GetAxis("Horizontal");
        float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -rotationAmount);
        transform.Translate(0, moveDirection.y, 0);
        // rb.velocity = moveDirection;
        // rb.rotation -= rotationAmount; //clockwise rotation
    }

}
