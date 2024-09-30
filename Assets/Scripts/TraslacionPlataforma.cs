using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraslacionPlataforma : MonoBehaviour
{
    [SerializeField] Vector3 movimiento;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(movimiento * 15 * Time.deltaTime);
        timer += 1 * Time.deltaTime;
        
        if (timer >= 5)
        {
            movimiento = -movimiento;
            timer = 0;
        }
    }
}
