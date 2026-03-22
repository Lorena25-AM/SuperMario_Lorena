using UnityEngine;

public class ParpadeoCalabaza : MonoBehaviour
{
    public float velocidad = 8f;

    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (sr == null) return;

        float t = Mathf.PingPong(Time.time * velocidad, 1f);

        // Cambia entre naranja y amarillo
        sr.color = Color.Lerp(Color.red, Color.yellow, t);
    }
}