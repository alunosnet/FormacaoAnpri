using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClicaDestroi : MonoBehaviour
{

    public Camera _camera;

    // Start is called before the first frame update
    void Start()
    {
        if (_camera == null)
            _camera = GameObject.FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Destroi();
        }
    }
    private void Destroi()
    {
        RaycastHit hit;
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        //Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
        if (Physics.Raycast(ray,out hit))
        {
            Transform obj = hit.transform;
            Destroy(obj.gameObject);
        }
    }
}
