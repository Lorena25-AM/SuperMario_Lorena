using UnityEngine;

public class CambiaAnimacion : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sr;
    private EstadoPersonaje estado;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        estado = GetComponentInChildren<EstadoPersonaje>();
    }

    void Update()
    {
        // Manda al Animator la velocidad horizontal
        animator.SetFloat("velocidad", Mathf.Abs(rb.linearVelocity.x));

        // Voltea el sprite si va a la izquierda
        if (rb.linearVelocity.x < -0.1f)
        {
            sr.flipX = true;
        }
        else if (rb.linearVelocity.x > 0.1f)
        {
            sr.flipX = false;
        }

        // Indica si está en el piso o no
        animator.SetBool("enPiso", estado.estaEnPiso);
    }
}
