using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class DemoScript : MonoBehaviour
{
    public float MultiplicaForca = 5;
    Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.velocity = transform.forward * Time.deltaTime * MultiplicaForca;
    }

    void Update()
    {
    }
}


