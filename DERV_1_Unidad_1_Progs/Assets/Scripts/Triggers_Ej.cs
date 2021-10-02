using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Triggers_Ej : MonoBehaviour
{

    public TextMeshProUGUI txt_puntaje;
    public TextMeshProUGUI txt_vida;

    int puntaje;
    int vida;

    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;
        vida = 100;

        StartCoroutine("corrutinaVida");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // vida--;
        // txt_vida.text = vida.ToString();
    }

    private void OnCollisionEnter (Collision collision )
    {
        string etiqueta = collision.gameObject.tag;
        string nombre;

        Debug.Log("Colisión con " + etiqueta);

        if (etiqueta.Equals("Enemy"))
        {
            nombre = collision.gameObject.name;

            GameObject gameOBJ;

            gameOBJ = GameObject.Find(nombre);

            Destroy(gameOBJ);

            puntaje++;

            txt_puntaje.text = puntaje.ToString();
        }
    }

    // Corrutina

    IEnumerator corrutinaVida ()
    {
        while(true)
        {

            vida -= 5;
            txt_vida.text = vida.ToString();

            yield return new WaitForSeconds(1.0f);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        string etiqueta = other.gameObject.tag;

        Debug.Log("Colisión con " + etiqueta);

        if (etiqueta.Equals("PowerUp"))
        {
            vida++;
            txt_vida.text = vida.ToString();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}
