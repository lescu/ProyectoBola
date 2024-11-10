using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sube_Baja1 : MonoBehaviour
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
        transform.Translate(movimiento * 7 * Time.deltaTime);
        timer += 1 *Time.deltaTime;
        
        if ( timer >= 4f)
        {
            movimiento = -movimiento;
            timer = 0;
        }
        
    }
}
