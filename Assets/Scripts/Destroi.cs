using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroi : MonoBehaviour
{
    public float _tempoVida = 3;

    void Start()
    {
        Destroy(this.gameObject, _tempoVida);   //passados os segundos indicados o objeto é removido
    }

}
