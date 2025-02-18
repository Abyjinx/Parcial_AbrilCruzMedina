using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    [SerializeField] private float fuerzaSalto;
    [SerializeField] private AudioClip sonidoSalto;
    [SerializeField] private AudioClip sonidoAgacharse;
    private Animator animator;
    private Rigidbody rb;
    private bool enSuelo;


    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && enSuelo)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, fuerzaSalto);
            enSuelo = false;
            animator.SetBool("Salto", true);
            AudioManager.instance.PlayEfectos(sonidoSalto);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            animator.SetBool("Agacharse", true);
            AudioManager.instance.PlayEfectos(sonidoAgacharse);
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            animator.SetBool("Agacharse", false);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            enSuelo = true;
            animator.SetBool("Salto", false);
        }
    }
}
