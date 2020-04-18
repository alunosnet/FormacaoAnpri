using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoRotate : MonoBehaviour
{
    public float angulo = 20;
    public Vector3 centro = new Vector3(0, 0, 0);
    void Update()
    {
        transform.RotateAround(centro,Vector3.up,angulo*Time.deltaTime);
    }
}
