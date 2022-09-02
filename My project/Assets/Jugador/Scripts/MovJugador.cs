using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovJugador : MonoBehaviour
{

    private Rigidbody2D rb;
    [Header("Movimiento")]

    private float movimientoHorizontal = 0f;
    [SerializeField] private float velMovimientoJug;
    [Range(0,0.3f)][SerializeField] private float suavizadoMov;

    private Vector3 velocidad = Vector3.zero;
    private bool mirarDerecha = true;


    [Header("Salto")]
    [SerializeField] private float fuerzaSalto;
    [SerializeField] private LayerMask ElSuelo;
    [SerializeField] private Transform ControladorSuelo;
    [SerializeField] private Vector3 dimensionCaja;
    [SerializeField] private bool EnSuelo;

    private bool salto = false;


     [Header("Salto")]
     private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movimientoHorizontal = Input.GetAxisRaw("Horizontal") * velMovimientoJug;

        animator.SetFloat("Horizontal", Mathf.Abs(movimientoHorizontal));

        if(Input.GetButtonDown("Jump"))
        {
            salto = true;
        }
    }

    void FixedUpdate()
    {
        //Mov
        EnSuelo = Physics2D.OverlapBox(ControladorSuelo.position,dimensionCaja, 0f, ElSuelo);
        animator.SetBool("enSuelo", EnSuelo);
       
        Mover(movimientoHorizontal * Time.deltaTime, salto);

        salto = false;
        
    }

    private void Mover(float mover, bool saltar)
    {
        Vector3 velObjetivo = new Vector2(mover,rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity,velObjetivo, ref velocidad, suavizadoMov);

        if(mover > 0 && !mirarDerecha)
        {
            Girar();
        } 
        else if(mover < 0 && mirarDerecha)
        {
            Girar();
        }

        if(EnSuelo && saltar)
        {
            EnSuelo= false;
            rb.AddForce(new Vector2(0f, fuerzaSalto));
        }
    }

    private void Girar()
    {
        mirarDerecha = !mirarDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(ControladorSuelo.position, dimensionCaja);
    }
}
