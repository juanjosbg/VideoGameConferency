using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{

    [SerializeField] private float vida;
    [SerializeField] private float Maxvida;
    [SerializeField] private BarraVida barradeVida;



    // Start is called before the first frame update
    void Start()
    {
       vida = Maxvida; 
    }

    public void TomarDaño(float daño)
    {
        vida -= daño;
        barradeVida.CambiarVidaAct(vida);
        if(vida <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Curar(float curacion)
    {
        if((vida + curacion)> Maxvida)
        {
            vida = Maxvida;
        }
        else
        {
            vida += curacion;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
