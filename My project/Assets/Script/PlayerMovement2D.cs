using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement2D : MonoBehaviour
{
    public float speed = 5f; // Hareket hýzý
    public float jumpForce = 10f; // Zýplama kuvveti
    private Rigidbody2D rb; // Rigidbody bileþeni

    void Start()
    {
        // Rigidbody bileþenini al
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Saða ve sola hareket kontrolü
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal * speed, rb.velocity.y);
        rb.velocity = movement;

        // Yukarý zýplama kontrolü
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
