using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFisicas : MonoBehaviour
{

    public float desplazamiento = 10;

    Rigidbody rb;

    //long i;

    // Start is called before the first frame update
    void Start()
    {
        //i = 0;

        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if(Input.GetKey(KeyCode.W))
        {
            Debug.Log("Adelante");
            rb.MovePosition(rb.position + transform.forward * desplazamiento * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Izquierda");
            rb.MovePosition(rb.position + transform.right * desplazamiento * Time.deltaTime * -1f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Atrás");
            rb.MovePosition(rb.position + transform.forward * desplazamiento * Time.deltaTime * -1f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Derecha");
            rb.MovePosition(rb.position + transform.right * desplazamiento * Time.deltaTime);
        }
    }
}
