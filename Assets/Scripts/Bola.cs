using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    Vector3 mover;
    float velocidad = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); // h = 1 (D � ->) h = -1 (A � <-), h = 0 (NADA)
        float v = Input.GetAxis("Vertical"); // v = 1 (w � ->) v = -1 (s � v), v = 0 (NADA)
        
        Vector3 mover = new Vector3 (h, 0, v);
        
        transform.Translate(mover * velocidad * Time.deltaTime);
    }
}
