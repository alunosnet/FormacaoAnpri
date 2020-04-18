using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarBola : MonoBehaviour
{
    public GameObject _modeloBola;
    public Transform _pontoAtirar;
    public float forcaAtirar = 5;
    void Update()
    {
        //atirar bola com fire1
        if (Input.GetButtonDown("Fire1"))
        {
            var objeto=Instantiate(_modeloBola,_pontoAtirar.position,Quaternion.identity);
            objeto.GetComponent<Rigidbody>().AddForce(transform.forward * forcaAtirar);
        }
    }
}
