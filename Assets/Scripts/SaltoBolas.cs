using UnityEngine;

public class SaltoBolas : MonoBehaviour
{
    public float fuerzaSalto = 5f; // Fuerza del salto, puedes ajustarla en el Inspector

    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtenemos el componente Rigidbody
        if (rb == null)
        {
            Debug.LogError("No se encontr� un componente Rigidbody en el objeto. A�ade un Rigidbody al objeto 'BluePlayer' para que el salto funcione.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Verificamos si se presiona la tecla Espacio y si hay un Rigidbody
        if (Input.GetKeyDown(KeyCode.Space) && rb != null)
        {
            // Cambiamos el modo de salto: en lugar de AddForce, asignamos directamente la velocidad en Y
            // Esto ignora la masa y la f�sica acumulada, dando un salto m�s consistente
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, fuerzaSalto, rb.linearVelocity.y);
        }
    }
}
