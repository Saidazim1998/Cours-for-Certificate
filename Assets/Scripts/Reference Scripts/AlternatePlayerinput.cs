using UnityEngine;
using UnityEngine.InputSystem;
public class AlternatePlayerinput : MonoBehaviour
{
    private Rigidbody rb;

    private float movementX;
    private float movementY;

    public float speed = 50;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0, movementY);
        rb.AddForce(movement * speed);
    }

    private void OnMove(InputValue value)
    {
        Vector2  movementVector2 = value.Get<Vector2>();
        movementX = movementVector2.x;
        movementY = movementVector2.y;
    }
}
