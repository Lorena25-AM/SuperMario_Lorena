using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class RegresarMenu1 : MonoBehaviour
{
    private Button regresar;

    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        regresar = root.Q<Button>("Regresar");

        if (regresar != null)
            regresar.clicked += VolverAlMenu;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            VolverAlMenu();
    }

    void VolverAlMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}