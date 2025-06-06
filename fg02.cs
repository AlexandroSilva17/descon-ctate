using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fg02 : MonoBehaviour
{
    public int puntos = 0; // los puntos iniciales
    public Text felipe; // el contador
    public Text elfinal; // el contador final
    public Text elfinal1; // el contador final

    // referencias para los paneles
    public GameObject panelkajav;
    public GameObject panelkajap;

    // (es una parte importante pero realmente no tanto, de cualquier manera, esto esta para
    // que funcione bien el juego)
    public Transform contenedorPadre;
    public GameObject panel;

    void Start()
    {
        felipe.text = "Puntos: 0"; // aca se fuerza que al inicio diga puntos y no newtext
        Time.timeScale = 0f;
        panel.SetActive(true); //panel de las instrucciones
        
        panelkajav.SetActive(false); // es que lo mas seguro es que no se oculten realmente igua-
        panelkajap.SetActive(false); // almente esta por las dudas
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector2(x, y) * Time.deltaTime * 7f);


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Libro"))
        {
            puntos += 5;
            Destroy(collision.gameObject);
        }
        else if (collision.CompareTag("Celular"))
        {
            puntos -= 5;
            Destroy(collision.gameObject);
        }

        felipe.text = "Puntos: " + puntos;
        elfinal.text = "Tu puntuacion fue de:" + puntos;
        elfinal1.text = "Tu puntuacion fue de:" + puntos;

        // aca verifica la victoria
        if (puntos >= 50)
        {
            panelkajav.SetActive(true);
            Time.timeScale = 0f; // clave para pausar el juego
        }
        // aca te manda literalmente a perdiste
        else if (puntos < 0)
        {
            panelkajap.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void ReiniciarJuego()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void tesak()
    {
        Time.timeScale = 1f;
        panel.SetActive(false);
    }
    public void tesakk()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;

    }
}
