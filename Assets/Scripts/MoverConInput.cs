using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoverConInput : MonoBehaviour
{
    
    [SerializeField]

    private InputAction accionMover;
    [SerializeField]
    private InputAction accionSalto;

    private Rigidbody2D rb;
    private float velocidadX = 7f;

    private float velocidadY = 7f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        accionMover.Enable();
        rb = GetComponent<Rigidbody2D>();
    }
    void OnEnable()
    {
        accionSalto.Enable();
        accionSalto.performed += saltar;
    }

    void OnDisable()
    {
        accionSalto.Disable();
        accionSalto.performed -= saltar;
    }
    public void saltar(InputAction.CallbackContext context)
    {
        rb.linearVelocityY = velocidadY;
    }


    // Update is called once per frame
    void Update()
    {
        Vector2 movimiento = accionMover.ReadValue<Vector2>();
        //transform.position = (Vector2)transform.position + Time.deltaTime * velocidadX * movimiento;
        rb.linearVelocityX = velocidadX * movimiento.x;
    }
}
