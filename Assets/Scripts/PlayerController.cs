using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private InputManager inputManager;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;

    private bool isGrounded;
    private Rigidbody rb;
    void Start()
    {
        // add event listeners
        inputManager.OnMove.AddListener(MovePlayer);
        inputManager.OnJump.AddListener(Jump);

        // initialization
        rb = GetComponent<Rigidbody>();
        isGrounded = true;
    }

    void MovePlayer(Vector2 direction)
    {
        Vector3 moveDirection = new(direction.x, 0f, direction.y);
        rb.AddForce(moveSpeed * moveDirection);
    }

    void Jump()
    {
        if (!isGrounded) return;
        rb.AddForce(Vector3.up * jumpForce);
        isGrounded = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        // need to know whether player collided w floor or wall
        // this gets the normal of the collision contact point
        // if up, then player hit the ground, but if pointing sideways
        // means player just hit a wall/side of a platform
        Vector3 normal = collision.contacts[0].normal;

        if (collision.gameObject.CompareTag("Ground") && normal == transform.up)
        {
            isGrounded = true;
        }
    }
}
