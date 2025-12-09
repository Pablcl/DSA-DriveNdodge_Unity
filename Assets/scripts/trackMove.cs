using UnityEngine;
using System.Collections;

public class trackMove : MonoBehaviour
{
    public float speed;      // Velocidad actual
    public float acc;        // Aceleración por segundo

    Vector2 poscarretera;

    void Update()
    {
        // Aumenta la velocidad progresivamente
        speed += acc * Time.deltaTime;

        // Mueve la textura en el eje Y según la velocidad
        poscarretera = new Vector2(0, Time.time * speed);

        GetComponent<Renderer>().material.mainTextureOffset = poscarretera;
    }
}
