using System.Security.Cryptography;
using UnityEngine;

public class SpawnObjetos : MonoBehaviour
{
    [SerializeField] private GameObject[] objetos;
    [SerializeField] private Transform[] puntosSpawn;
    [SerializeField] private float tiempoSpawn = 1f;

    private void Start()
    {
        InvokeRepeating("InstanciarObjeto", 1f, tiempoSpawn);
    }

    public void InstanciarObjeto()
    {
        int spawn = Random.Range(0, 3);

        Instantiate(objetos[spawn], puntosSpawn[spawn].position, Quaternion.identity);
    }
}
