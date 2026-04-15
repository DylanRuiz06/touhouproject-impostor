using UnityEngine;

public class NaveMovimiento : MonoBehaviour
{
    [Header("Velocidad de movimiento")]
    public float velocidad = 5f;

    private Rigidbody2D rb;
    private Vector2 movimiento;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Captura input de las flechas (o WASD también funciona)
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        movimiento = new Vector2(moveX, moveY).normalized;
    }

    void FixedUpdate()
    {
        // Movimiento físico
        rb.linearVelocity = movimiento * velocidad;
    }
}