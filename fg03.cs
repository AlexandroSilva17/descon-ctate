using UnityEngine;

public class fg03 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // tecnicamente aca le pedimos que vea si es un libro o un telefono para luego en "destroy" 
        // poder sacarlo y asi "optimizar el juego"
        
        if (other.CompareTag("Libro") || other.CompareTag("Celular"))
        {
            Destroy(other.gameObject);
        }
    }
}
