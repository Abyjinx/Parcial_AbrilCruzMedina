using UnityEngine;
using UnityEngine.SceneManagement;

public class Objeto : MonoBehaviour
{
    [SerializeField] private AudioClip sonidoMuerte;
    [SerializeField] private float velocidadObjeto = 5f;
    private Puntaje puntajeScr;

    private void Start()
    {
        puntajeScr = FindAnyObjectByType<Puntaje>();
    }
    private void Update()
    {
        transform.position += Vector3.left * velocidadObjeto * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Jugador"))
        {
            AudioManager.instance.PlayEfectos(sonidoMuerte);
            Invoke("ReiniciarEscena", .5f);
        }
        else if (other.gameObject.CompareTag("ZonaFuera"))
        {
            puntajeScr.AgregarPunto();
            Destroy(gameObject);
        }
    }

    private void ReiniciarEscena()
    {
        SceneManager.LoadScene(0);
    }
}
