using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class Editar : MonoBehaviour
{
	
	[SerializeField]
    GameObject panelMSG; //Objeto para manipular el panel donde se muestran los mensajes al presionar "agregar"
	
	public Text texto; //Variable para mostra mensaje en el panel
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void EditarEspacio(string nombre){
        
        if (nombre == "1") //Espacio 1
		{
            if (PlayerPrefs.GetInt("PISO1A") == 1) //Espacio activo
			{
                PlayerPrefs.SetInt("EDITAR", 1);
                SetBitacora("El usuario entro a editar el espacio " + nombre);
                SceneManager.LoadScene("Espacio_Editar");
            }
			else //Espacio inactivo
			{
				texto.text = "El espacio " + nombre + " no existe";
				mostrar();
                SetBitacoraError("El espacio " + nombre + " no se puede editar porque no esta activo");
            }
        }else if(nombre == "2") //Espacio 2
		{
            if (PlayerPrefs.GetInt("PISO2A") == 1) //Espacio activo
			{
                PlayerPrefs.SetInt("EDITAR", 2);
                SetBitacora("El usuario entro a editar el espacio " + nombre);
                SceneManager.LoadScene("Espacio_Editar");
            }
			else //Espacio inactivo
			{
				texto.text = "El espacio " + nombre + " no existe";
				mostrar();
                SetBitacoraError("El espacio " + nombre + " no se puede editar porque no esta activo");
            }
        }
		else if(nombre == "3") //Espacio 3
		{
            if (PlayerPrefs.GetInt("PISO3A") == 1) //Espacio activo
			{
                PlayerPrefs.SetInt("EDITAR", 3);
                SetBitacora("El usuario entro a editar el espacio " + nombre);
                SceneManager.LoadScene("Espacio_Editar");
            }
			else //Espacio inactivo
			{
				texto.text = "El espacio " + nombre + " no existe";
				mostrar();
                SetBitacoraError("El espacio " + nombre + " no se puede editar porque no esta activo");
            }
        }
		else if(nombre == "4") //Espacio 4
		{
            if (PlayerPrefs.GetInt("PISO4A") == 1) //Espacio activo
			{
                PlayerPrefs.SetInt("EDITAR", 4);
                SetBitacora("El usuario entro a editar el espacio " + nombre);
                SceneManager.LoadScene("Espacio_Editar");
            }
			else //Espacio inactivo
			{
				texto.text = "El espacio " + nombre + " no existe";
				mostrar();
                SetBitacoraError("El espacio " + nombre + " no se puede editar porque no esta activo");
            }
        }
		else if(nombre == "5") //Espacio 5
		{
            if (PlayerPrefs.GetInt("PISO5A") == 1) //Espacio activo
			{
                PlayerPrefs.SetInt("EDITAR", 5);
                SetBitacora("El usuario entro a editar el espacio " + nombre);
                SceneManager.LoadScene("Espacio_Editar");
            }
			else //Espacio inactivo
			{
				texto.text = "El espacio " + nombre + " no existe";
				mostrar();
                SetBitacoraError("El espacio " + nombre + " no se puede editar porque no esta activo");
            }
        }
		else if(nombre == "6") //Espacio 6
		{
            if (PlayerPrefs.GetInt("PISO6A") == 1) //Espacio activo
			{
                PlayerPrefs.SetInt("EDITAR", 6);
                SetBitacora("El usuario entro a editar el espacio " + nombre);
                SceneManager.LoadScene("Espacio_Editar");
            }
			else //Espacio inactivo
			{
				texto.text = "El espacio " + nombre + " no existe";
				mostrar();
                SetBitacoraError("El espacio " + nombre + " no se puede editar porque no esta activo");
            }
        }
    }
	
	public void SetBitacora(string txt){
        StreamWriter wr = new StreamWriter("Logs/bitacora_201025406_201404006.txt", true);
        wr.WriteLine("[Accion]::"+txt);
        wr.Close();
    }

    public void SetBitacoraError(string txt){
        StreamWriter wr = new StreamWriter("Logs/bitacora_201025406_201404006.txt", true);
        wr.WriteLine("[Error]::"+txt);
        wr.Close();
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
