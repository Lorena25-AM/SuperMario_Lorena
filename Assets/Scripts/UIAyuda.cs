using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UIAyuda : MonoBehaviour
{
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;

        Button cerrar = root.Q<Button>("Cerrar");
        Button salir = root.Q<Button>("Salir");

        if (cerrar != null)
            cerrar.clicked += VolverAlMenu;

        if (salir != null)
            salir.clicked += VolverAlMenu;
    }

    void VolverAlMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
