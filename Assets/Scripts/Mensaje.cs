using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;


public class Mensaje : MonoBehaviour
{
	
	[SerializeField]
    GameObject panelMSG;
	public Text texto = null;
    // Start is called before the first frame update
    void Start()
    {
        texto.text = "Espacio creado correctamente";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	//Sirve para mostrar el panel que contendrá el mensaje
	public void mostrar(){
        this.panelMSG.SetActive(true);
    }

	//Sirve para ocultar el panel del mensaje
    public void cerrar(){
        this.panelMSG.SetActive(false);
    }
}
