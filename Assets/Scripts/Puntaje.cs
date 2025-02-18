using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    [SerializeField] private AudioClip sonidoPuntaje;
    [SerializeField] private TextMeshProUGUI puntajeTexto; 
    private int puntaje = 0;


    public void AgregarPunto()
    {
        puntaje++;
        AudioManager.instance.PlayEfectos(sonidoPuntaje);
        puntajeTexto.text = "Obstaculos superados: " + puntaje;
    }
}
