using UnityEngine;

public class EstadoPersonaje : MonoBehaviour
{
    public bool estaEnPiso;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            estaEnPiso = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            estaEnPiso = false;
        }
    }
}