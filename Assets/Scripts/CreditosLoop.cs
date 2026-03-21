using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class CreditosLoop : MonoBehaviour
{
    public float velocidad = 30f;

    private Label textoCreditos;
    private Button cerrar;

    private float posicionInicial;
    private float posicionFinal = -600f;

    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        textoCreditos = root.Q<Label>("TextoCreditos");
        cerrar = root.Q<Button>("Cerrar");

        if (textoCreditos != null)
        {
            posicionInicial = Screen.height;
            textoCreditos.style.top = posicionInicial;
        }

        if (cerrar != null)
        {
            cerrar.clicked += () =>
            {
                SceneManager.LoadScene("Menu");
            };
        }
    }

    void Update()
    {
        if (textoCreditos == null) return;

        float topActual = textoCreditos.resolvedStyle.top;
        float nuevoTop = topActual - velocidad * Time.deltaTime;

        if (nuevoTop < posicionFinal)
        {
            nuevoTop = posicionInicial;
        }

        textoCreditos.style.top = nuevoTop;
    }
}
