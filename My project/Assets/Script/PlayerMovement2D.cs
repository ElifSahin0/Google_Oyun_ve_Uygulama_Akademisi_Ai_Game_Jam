using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement2D : MonoBehaviour
{
    public float speed = 5f; // Hareket h�z�
    public float jumpForce = 10f; // Z�plama kuvveti
    private Rigidbody2D rb; // Rigidbody bile�eni

    void Start()
    {
        // Rigidbody bile�enini al
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Sa�a ve sola hareket kontrol�
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal * speed, rb.velocity.y);
        rb.velocity = movement;

        // Yukar� z�plama kontrol�
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
