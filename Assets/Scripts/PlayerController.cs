using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private InputManager inputManager;
    [SerializeField] private float moveSpeed;
    private Rigidbody rb;
    void Start()
    {
        // add event listener
        inputManager.OnMove.AddListener(MovePlayer);
        // get ref to rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void MovePlayer(Vector2 direction)
    {
        Vector3 moveDirection = new(direction.x, 0f, direction.y);
        rb.AddForce(moveSpeed * moveDirection);
    }
}
