using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{

    private Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    public void CambiarVidaMax(float vidaMax)
    {
        slider.maxValue = vidaMax;
    }

    public void CambiarVidaAct(float cantVida)
    {
        slider.value = cantVida;
    }


    public void InicializarBarradeVida(float cantVida)
    {
        CambiarVidaMax(cantVida);
        CambiarVidaAct(cantVida);
    }

}
