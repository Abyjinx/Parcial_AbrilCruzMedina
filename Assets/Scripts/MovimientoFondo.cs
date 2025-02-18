using UnityEngine;

public class MovimientoFondo : MonoBehaviour
{
    [SerializeField] private float velocidad = 1f;
    [SerializeField] private Renderer imagen;
    [SerializeField] private Vector2 offset;

    private void Start()
    {
        imagen = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        offset = new Vector2(Time.time * velocidad, 0);
        imagen.material.mainTextureOffset = offset;
    }
}
