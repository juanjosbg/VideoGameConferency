using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combate : MonoBehaviour
{

    [SerializeField] private Transform controlGolpe;
    [SerializeField] private float radioGolpe;
    [SerializeField] private float dañoGolpe;



    private void Golpe()
    {
        Collider2D[] objetos = Physics2D.OverlapCircleAll(controlGolpe.position,radioGolpe);

        foreach(Collider2D colisionador in objetos)
        {
            if(colisionador.CompareTag("Enemigo"))
            {
                colisionador.transform.GetComponent<Enemigo>().TomarDaño(dañoGolpe);
            }
        }
    }

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Golpe();
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(controlGolpe.position,radioGolpe);
    }

}
