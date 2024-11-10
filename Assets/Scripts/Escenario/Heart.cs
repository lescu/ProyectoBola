using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    Vector3 rotacion = new Vector3 (0, 10, 0);
    Vector3 movimiento = new Vector3(0, 2, 0);
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotacion * 10 * Time.deltaTime, Space.World);
        //transform.Translate(movimiento * 5 * Time.deltaTime, Space.World);
        timer += 1 * Time.deltaTime;
        if (timer >= 5)
        {
            movimiento = -movimiento;
            timer = 0;
        }
    }
}
