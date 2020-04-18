using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public float raioExplosao = 10.0f;
    public float forcaExplosao = 10.0f;
    public ParticleSystem efeitoExplosao;
    public int DanoBomba = 50;

    AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        Invoke("Explosao", 2);
    }

    public void Explosao()
    {
        //toca o som
        _audioSource.Play();

        Debug.Log("Explode");
        Vector3 posicaoExplosao = transform.position;
        //coleção dos colliders dentro do raio da explosão
        Collider[] colliders = Physics.OverlapSphere(posicaoExplosao, raioExplosao);
        //para cada collider
        foreach (Collider obj in colliders)
        {
            //se tem ridigbody
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            if (rb != null) //aplica forção de explosão
                rb.AddExplosionForce(forcaExplosao, posicaoExplosao, raioExplosao, 3.0f);
            //se tem componente de saude perde vida
            Saude pl = obj.GetComponent<Saude>();
            if (pl != null)
                pl.retiraVida(DanoBomba);
        }
        //se existir algum sistema de particulas para
        //fazer o efeito da explosão é executado
        if (efeitoExplosao != null)
            efeitoExplosao.Play();
        
        //esconde a bola explosiva
        this.GetComponent<Renderer>().enabled = false;
        //só destroi a bola passado um 1 segundo se não o som não se ouve
        Destroy(this.gameObject,1);
    }
}
