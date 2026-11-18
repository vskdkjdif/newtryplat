using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;

    Vector2 moveVector;
    Rigidbody2D playerRB;

    private void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("Jump");
            Jump();
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveVector = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        playerRB.linearVelocity = new Vector2(moveVector.x * moveSpeed, playerRB.linearVelocity.y);
    }

    void Jump()
    {
        playerRB.linearVelocityY = 0;
        playerRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
