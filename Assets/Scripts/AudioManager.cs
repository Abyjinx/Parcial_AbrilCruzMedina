using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource efectos;
    [SerializeField] private AudioSource musica;
    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void PlayEfectos(AudioClip clip)
    {
        efectos.PlayOneShot(clip);
    }

    public void PlayMusica(AudioClip clip)
    {
        musica.clip = clip;
        musica.loop = true;
        musica.Play();
    }

}
