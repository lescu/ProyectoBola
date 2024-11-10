using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodillo_Golpeador : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 direccionR;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(direccionR * 250, ForceMode.VelocityChange);
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(new Vector3(0, 1, 0) * 1000 * Time.deltaTime, Space.World); ->  No tiene fisicas

        // Giro con fisicas:
    }
}
