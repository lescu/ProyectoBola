using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodillo_Gigante : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 direccionR;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(direccionR * 5, ForceMode.VelocityChange);    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
