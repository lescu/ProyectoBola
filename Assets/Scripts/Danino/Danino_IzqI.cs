using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danino_IzqI : MonoBehaviour
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
        transform.Translate(movimiento * -5 * Time.deltaTime);
        timer += 1 * Time.deltaTime;

        if (timer >= 0.75f)
        {
            movimiento = -movimiento;
            timer = 0;
        }
    }
}
