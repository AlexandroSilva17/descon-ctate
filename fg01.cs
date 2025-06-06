using UnityEngine;
using UnityEngine.SceneManagement;  

public class fg01 : MonoBehaviour
{
    // cuando hablo de cofpan quiero hacerle referencia al panel en el inicio
    public GameObject cofpan;

    public void escena1()
    {
        // esta es la escena del juego jaja
        SceneManager.LoadScene("peru"); 
    }
    // aqui la funcion para quitar la app
    public void piopiopiow()
    {
        Application.Quit();
    }

    // lo cierro o lo hago ver con la variables fjpan o fjjpan
    public void fjpan()
    {
        cofpan.SetActive(true);
    }
    public void fjjpan()
    {
        cofpan.SetActive(false);
    }

}
