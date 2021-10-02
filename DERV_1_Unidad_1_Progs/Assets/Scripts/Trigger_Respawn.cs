using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Trigger_Respawn : MonoBehaviour
{

    public GameObject posInicio;
    public GameObject objetoLanzar;
    int i;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger con: " + other.name);

        if(other.tag.Equals("Player"))
        {
            GameObject obj =
                Instantiate
                (
                    objetoLanzar,
                    posInicio.transform.position,
                    posInicio.transform.rotation
                )
                as GameObject;

            obj.name = "Enemy_" + i;

            Destroy(obj, 4f);
        }
    }
}