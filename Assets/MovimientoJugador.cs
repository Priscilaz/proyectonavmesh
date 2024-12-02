using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento del jugador

    void Update()
    {
        // Obtener entrada del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Crear un vector de movimiento
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical);

        // Aplicar movimiento al personaje
        transform.Translate(movimiento * velocidad * Time.deltaTime, Space.World);
    }
}
