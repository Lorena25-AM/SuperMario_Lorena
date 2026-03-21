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

        jugar.clicked += IrAJuego;
        ayuda.clicked += IrAAyuda;
        creditos.clicked += IrACreditos;
    }

    void IrAJuego()
    {
        SceneManager.LoadScene("Juego");
    }

    void IrAAyuda()
    {
        SceneManager.LoadScene("Ayuda");
    }

    void IrACreditos()
    {
        SceneManager.LoadScene("Creditos");
    }
}