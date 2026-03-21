using UnityEngine;

public class PatrullaToad : MonoBehaviour
{
    public Transform puntoIzquierdo;
    public Transform puntoDerecho;
    public float velocidad = 1.5f;

    private SpriteRenderer sr;
    private bool yendoDerecha = true;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (yendoDerecha)
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                new Vector2(puntoDerecho.position.x, transform.position.y),
                velocidad * Time.deltaTime
            );

            sr.flipX = false;

            if (Mathf.Abs(transform.position.x - puntoDerecho.position.x) < 0.01f)
            {
                yendoDerecha = false;
            }
        }
        else
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                new Vector2(puntoIzquierdo.position.x, transform.position.y),
                velocidad * Time.deltaTime
            );

            sr.flipX = true;

            if (Mathf.Abs(transform.position.x - puntoIzquierdo.position.x) < 0.01f)
            {
                yendoDerecha = true;
            }
        }
    }
}