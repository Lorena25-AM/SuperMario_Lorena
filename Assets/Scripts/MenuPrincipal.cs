using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuPrincipal : MonoBehaviour
{
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        Button jugar = root.Q<Button>("Jugar");
        Button ayuda = root.Q<Button>("Ayuda");
        Button creditos = root.Q<Button>("Creditos");
        Button salir = root.Q<Button>("Salir");

        if (jugar != null)
            jugar.clicked += () => SceneManager.LoadScene("Juego_Mario");

        if (ayuda != null)
            ayuda.clicked += () => SceneManager.LoadScene("Ayuda");

        if (creditos != null)
            creditos.clicked += () => SceneManager.LoadScene("Creditos");

        if (salir != null)
            salir.clicked += SalirDelJuego;
    }

    void SalirDelJuego()
    {
        Application.Quit();
        Debug.Log("Salir del juego");
    }
}