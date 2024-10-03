using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class Bola : MonoBehaviour
{
    Vector3 mover;
    float fuerzaSALT = 10f;
    Rigidbody rb;
    

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); // h = 1 (D ó ->) h = -1 (A ó <-), h = 0 (NADA)
        float v = Input.GetAxis("Vertical"); // v = 1 (w ó ->) v = -1 (s ó v), v = 0 (NADA)

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * fuerzaSALT, ForceMode.Impulse);
        }
        Vector3 mover = new Vector3 (h, 0, v);
        
        transform.Translate(mover * fuerzaSALT,ForceMode.Impulse);
    }
}
