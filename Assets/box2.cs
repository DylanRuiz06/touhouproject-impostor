using UnityEngine;

public class WrapHorizontal : MonoBehaviour
{
    [Header("Límites de pantalla")]
    public float limiteIzquierdo = -9f;
    public float limiteDerecho = 9f;

    void Update()
    {
        Vector3 pos = transform.position;

        if (pos.x > limiteDerecho)
        {
            pos.x = limiteIzquierdo;
        }
        else if (pos.x < limiteIzquierdo)
        {
            pos.x = limiteDerecho;
        }

        transform.position = pos;
    }
}