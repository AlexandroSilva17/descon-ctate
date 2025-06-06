using UnityEngine;
using UnityEngine.SceneManagement;
public class alfa2 : MonoBehaviour
{
    public GameObject kajus;
    private bool pausado = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausado)
            {
                Loquero();
            }
            else
            {
                PausarJuego();
            }
        }
    }

    public void PausarJuego()
    {
        kajus.SetActive(true);
        Time.timeScale = 0f;
        pausado = true;
    }

    public void Loquero()
    {
        kajus.SetActive(false);
        Time.timeScale = 1f;
        pausado = false;
    }
    public void quieroirmeyadeestejuego()
    {
        SceneManager.LoadScene("menu");

    }
    public void lapeorfuncionyobligada()
    {
        kajus.SetActive(false);

    }
}

