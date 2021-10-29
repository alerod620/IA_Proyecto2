using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Cambiar_escena : MonoBehaviour
{
    public void LoadScene(string nombre){
        //***************************************
        StreamWriter wr = new StreamWriter("Logs/bitacora_201025406_201404006.txt", true);
        wr.WriteLine("[Accion]::El usuario se cambio a escena: '" + nombre + "'");
        wr.Close();
        //***************************************
        SceneManager.LoadScene(nombre);
    }
}
