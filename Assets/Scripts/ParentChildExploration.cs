using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentChildExploration : MonoBehaviour
{
    public GameObject filho;
    // Start is called before the first frame update
    void Start()
    {
        //filho.transform.parent = null;
        Debug.Log("Posicao:" + filho.transform.position + " posição local:"+filho.transform.localPosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
