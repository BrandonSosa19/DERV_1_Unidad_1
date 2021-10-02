using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscenas : MonoBehaviour
{
    public void IniciarJuego ()
    {
        SceneManager.LoadScene(2);
    }
}
