using UnityEngine;

public class fg04 : MonoBehaviour
{
    public GameObject libroPrefab;
    public GameObject celularPrefab;

    public float pan = 2f;
    public float rangoX = 8f;
    public float alturaSpawn = 6f;

    void Start()
    {
        InvokeRepeating("SpawnearObjeto", 1f, pan);
    }

    void SpawnearObjeto()
    {
        Vector2 posicionRandom = new Vector2(
            Random.Range(-rangoX, rangoX),
            alturaSpawn
        );

        int azar = Random.Range(0, 2); // 0 = celular, 1 = libro

        if (azar == 0)
        {
            Instantiate(celularPrefab, posicionRandom, Quaternion.identity);
        }
        else
        {
            Instantiate(libroPrefab, posicionRandom, Quaternion.identity);
        }
    }
}
