using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter (Collision collision )
    {
        string nombre = collision.gameObject.name;
        Debug.Log("Colisión con " + nombre);

        if (!nombre.Equals("Plane"))
        {
            GameObject gameOBJ;

            gameOBJ = GameObject.Find(nombre);

            Destroy(gameOBJ);
        }
    }

    private void OnCollisionStay (Collision collision)
    {

    }

    private void OnCollisionExit (Collision collision)
    {

    }

}
