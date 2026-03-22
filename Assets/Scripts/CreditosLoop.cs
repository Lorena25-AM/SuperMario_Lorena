using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class CreditosLoop : MonoBehaviour
{
    public float velocidad = 32f;

    private VisualElement scrollCreditos;
    private Button cerrar;

    private float posicionY;
    private float posicionInicialY;
    private float posicionFinalY;

    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        scrollCreditos = root.Q<VisualElement>("ScrollCreditos");
        cerrar = root.Q<Button>("Cerrar");

        if (cerrar != null)
        {
            cerrar.clicked += () =>
            {
                SceneManager.LoadScene("Menu");
            };
        }

        if (scrollCreditos != null)
        {
            scrollCreditos.style.position = Position.Absolute;
            scrollCreditos.style.left = 0;
            scrollCreditos.style.right = 0;

            root.schedule.Execute(() =>
            {
                // Donde empieza (tu posición actual)
                posicionInicialY = scrollCreditos.resolvedStyle.top;

                // Cuando ya desapareció completamente arriba
                posicionFinalY = -scrollCreditos.layout.height - 50f;

                posicionY = posicionInicialY;
            }).StartingIn(200);
        }
    }

    void Update()
    {
        if (scrollCreditos == null) return;
        if (scrollCreditos.layout.height <= 0) return;

        posicionY -= velocidad * Time.deltaTime;
        scrollCreditos.style.top = posicionY;

        // Cuando desaparece arriba → vuelve al inicio
        if (posicionY < posicionFinalY)
        {
            posicionY = posicionInicialY;
            scrollCreditos.style.top = posicionY;
        }
    }
}