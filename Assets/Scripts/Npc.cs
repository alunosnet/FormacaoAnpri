using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    GameObject player;
    Color inicial;
    Color vermelho = Color.red;

    void Start()
    {
        inicial = gameObject.GetComponent<Renderer>().material.color;
        if (player == null)
            player = GameObject.FindObjectOfType<MovePlayer>().gameObject;
    }

    void Update()
    {
        if (Utils.CanYouSeeThis(this.transform.position, player.transform.position))
            gameObject.GetComponent<Renderer>().material.color = vermelho;
        else
            gameObject.GetComponent<Renderer>().material.color = inicial;
    }
}
