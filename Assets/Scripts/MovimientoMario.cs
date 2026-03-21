using UnityEngine;

public class MovimientoMario : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
    public float fuerzaSalto = 7f;

    private Rigidbody2D rb;
    private EstadoPersonaje estado;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        estado = GetComponentInChildren<EstadoPersonaje>();
    }

    void Update()
    {
        float movimientoHorizontal = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(movimientoHorizontal * velocidadMovimiento, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && estado.estaEnPiso)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, fuerzaSalto);
        }
    }
}
