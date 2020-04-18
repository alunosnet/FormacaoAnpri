using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float velocidadeAndar=5;
    public float velocidadeRodar = 5;
    CharacterController _characterController;
    private float inputAndar;
    private float inputRodar;

    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        inputAndar = Input.GetAxis("Vertical"); //andar para frente e para trás
        inputRodar = Input.GetAxis("Horizontal");   //rodar para esquerda e direita

        Vector3 novaPosicao = transform.forward * velocidadeAndar * inputAndar;
        novaPosicao.y = Physics.gravity.y;

        _characterController.Move(novaPosicao * Time.deltaTime);

        _characterController.transform.Rotate(_characterController.transform.up * velocidadeRodar * inputRodar);

    }
}
