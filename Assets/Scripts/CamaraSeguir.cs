using UnityEngine;

public class CamaraSeguir : MonoBehaviour
{
    public Transform mario;
    public float suavizado = 5f;
    public float offsetX = 2f;

    public float limiteIzquierdo = 0f;
    public float limiteDerecho = 20f;

    void LateUpdate()
    {
        if (mario == null) return;

        float objetivoX = mario.position.x + offsetX;
        objetivoX = Mathf.Clamp(objetivoX, limiteIzquierdo, limiteDerecho);

        Vector3 nuevaPos = new Vector3(
            objetivoX,
            transform.position.y,
            transform.position.z
        );

        transform.position = Vector3.Lerp(transform.position, nuevaPos, suavizado * Time.deltaTime);
    }
}
