using UnityEngine;

public class TeleportHorizontal : MonoBehaviour
{
    [Header("Destino en X")]
    public float destinoX;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica que sea el jugador (por tag)
        if (other.CompareTag("Player"))
        {
            Vector3 pos = other.transform.position;
            pos.x = destinoX;
            other.transform.position = pos;
        }
    }
}