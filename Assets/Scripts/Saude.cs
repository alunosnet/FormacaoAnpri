using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saude : MonoBehaviour
{
    [SerializeField]
    int vida = 100;

    public int GetVida()
    {
        return vida;
    }

    public void retiraVida(int valor)
    {
        vida -= valor;
    }
}
