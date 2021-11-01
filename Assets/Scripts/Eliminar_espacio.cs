using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Eliminar_espacio : MonoBehaviour
{
	
	[SerializeField]
    GameObject panelMSG; //Objeto para manipular el panel donde se muestran los mensajes al presionar "agregar"
	
	public Text texto; //Variable para mostra mensaje en el panel
	
    // Start is called before the first frame update
    void Start()
    {
        
    }
	
	public void EliminarEspacio(string nombre){
		
        if(nombre == "1") //Espacio 1
		{
            if (PlayerPrefs.GetInt("PISO1A") == 1) //Si existe
			{
                SetBitacora("El usuario elimino el espacio 1");
                PlayerPrefs.SetInt("PISO1A",0);
				texto.text = "Espacio 1 eliminado con exito";
            }
			else //No existe
			{
                SetBitacoraError("El espacio 1 no existe");
				texto.text = "Espacio 1 no existe";
            }
        }
		else if(nombre == "2") //Espacio 2
		{
            if (PlayerPrefs.GetInt("PISO2A") == 1) //Si existe
			{
                SetBitacora("El usuario elimino el espacio 2");
                PlayerPrefs.SetInt("PISO2A",0);
				texto.text = "Espacio 2 eliminado con exito";
            }
			else //No existe
			{
                SetBitacoraError("El espacio 2 no existe");
				texto.text = "Espacio 2 no existe";
            }
        }
		else if(nombre == "3") //Espacio 3
		{
            if (PlayerPrefs.GetInt("PISO3A") == 1) //Si existe
			{
                SetBitacora("El usuario elimino el espacio 3");
                PlayerPrefs.SetInt("PISO3A",0);
				texto.text = "Espacio 3 eliminado con exito";
            }
			else //No existe
			{
                SetBitacoraError("El espacio 3 no existe");
				texto.text = "Espacio 3 no existe";
            }
        }
		else if(nombre == "4") //Espacio 4
		{
            if (PlayerPrefs.GetInt("PISO4A") == 1) //Si existe
			{
                SetBitacora("El usuario elimino el espacio 4");
                PlayerPrefs.SetInt("PISO4A",0);
				texto.text = "Espacio 4 eliminado con exito";
            }
			else //No existe
			{
                SetBitacoraError("El espacio 4 no existe");
				texto.text = "Espacio 4 no existe";
            }
        }
		else if(nombre == "5") //Espacio 5
		{
            if (PlayerPrefs.GetInt("PISO5A") == 1) //Si existe
			{
                SetBitacora("El usuario elimino el espacio 5");
                PlayerPrefs.SetInt("PISO5A",0);
				texto.text = "Espacio 5 eliminado con exito";
            }
			else //No existe
			{
                SetBitacoraError("El espacio 5 no existe");
				texto.text = "Espacio 5 no existe";
            }
        }
		else if(nombre == "6") //Espacio 6
		{
            if (PlayerPrefs.GetInt("PISO6A") == 1) //Si existe
			{
                SetBitacora("El usuario elimino el espacio 6");
                PlayerPrefs.SetInt("PISO6A",0);
				texto.text = "Espacio 6 eliminado con exito";
            }
			else //No existe
			{
                SetBitacoraError("El espacio 6 no existe");
				texto.text = "Espacio 6 no existe";
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
