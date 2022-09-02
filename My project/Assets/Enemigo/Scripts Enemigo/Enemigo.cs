using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{

    

    [Header("Vida")]
    [SerializeField] private float vida;
    [SerializeField] private BarraVida barradeVida;
    
    private Animator animator;

    private Rigidbody2D rb;

    public Transform jugador;

    private bool mirarDerecha = true;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        barradeVida.InicializarBarradeVida(vida);
        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    public void TomarDaño(float daño)
    {
        vida -= daño;

        if(vida <=0)
        {
            Muerte();
        }
    }

    private void Muerte()
    {
        animator.SetTrigger("Muerte");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
