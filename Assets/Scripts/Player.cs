using UnityEngine;

public class Player : MonoBehaviour
{
    [field:SerializeField] public float moveSpeed { get; private set; } = 5f;
    [field: SerializeField] public float jumpForce { get; private set; } = 10f;

    [field: SerializeField] public bool isInvulnerable { get; private set; } = false;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2 (moveInput * moveSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }
    // Set Move Speed
    public void SetMoveSpeed(float speed)
    {
        moveSpeed = speed;
        Debug.Log($"Set Player Speed To {moveSpeed}");
    }
    public void SetInvulnerability(bool isEnabled)
    {
        isInvulnerable = isEnabled;
        Debug.Log($"Set Player Invulnerable To {isInvulnerable}");
    }

    // On Touched to something that get power up
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PowerUpBase powerUp = collision.gameObject.GetComponent<PowerUpBase>();
        if (powerUp != null)
        {
            powerUp.ApplyEffect(this);
        }
    }
}
