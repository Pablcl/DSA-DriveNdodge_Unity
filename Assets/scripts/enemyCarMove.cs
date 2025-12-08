using UnityEngine;

public class enemyCarMove : MonoBehaviour
{
    public float speed2;          // Velocidad del coche
    private Vector2 poscarretera2; // Posición actual

    void Start()
    {
        poscarretera2 = new Vector2(1, 3.53f); // Posición inicial
        transform.position = poscarretera2;
    }

    void Update()
    {
        // Movimiento hacia abajo usando deltaTime
        poscarretera2.y = poscarretera2.y + speed2 * Time.deltaTime;

        transform.position = poscarretera2;
    }
}
