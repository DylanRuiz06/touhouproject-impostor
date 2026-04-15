using UnityEngine;

public class EnemigoPatrullaHorizontal : MonoBehaviour
{
    [Header("Movimiento")]
    public float velocidad = 3f;

    [Header("Cambio de dirección")]
    public float tiempoMin = 1f;
    public float tiempoMax = 3f;

    [Header("Límites")]
    public float limiteIzquierdo = -2f;
    public float limiteDerecho = 2f;

    private Rigidbody2D rb;
    private float direccion = 1f;
    private float temporizador;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        CambiarDireccion();
    }

    void Update()
    {
        temporizador -= Time.deltaTime;

        if (temporizador <= 0f)
        {
            CambiarDireccion();
        }
    }

    void FixedUpdate()
    {
        float nuevaX = direccion * velocidad;

        rb.velocity = new Vector2(nuevaX, 0f);

        // Forzar límites
        if (transform.position.x <= limiteIzquierdo)
        {
            transform.position = new Vector2(limiteIzquierdo, transform.position.y);
            direccion = 1f; // ir a la derecha
        }
        else if (transform.position.x >= limiteDerecho)
        {
            transform.position = new Vector2(limiteDerecho, transform.position.y);
            direccion = -1f; // ir a la izquierda
        }
    }

    void CambiarDireccion()
    {
        direccion = Random.value < 0.5f ? -1f : 1f;
        temporizador = Random.Range(tiempoMin, tiempoMax);
    }
}