using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Ver_espacio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("PISO1A: "+ (PlayerPrefs.GetInt("PISO1A")));
        print("PISO2A: "+ (PlayerPrefs.GetInt("PISO2A")));
        print("PISO3A: "+ (PlayerPrefs.GetInt("PISO3A")));
		print("PISO4A: "+ (PlayerPrefs.GetInt("PISO4A")));
        print("PISO5A: "+ (PlayerPrefs.GetInt("PISO5A")));
        print("PISO6A: "+ (PlayerPrefs.GetInt("PISO6A")));
    }

    public void VerEspacio(string nombre){
        
        if (nombre == "1") //Espacio 1
		{
            if (PlayerPrefs.GetInt("PISO1A") == 1) //Espacio activo
			{
                PlayerPrefs.SetInt("CARGAR", 1);
                SetBitacora("El cargo el espacio " + nombre);
                SceneManager.LoadScene("Espacios");
            }
			else //Espacio inactivo
			{
                SetBitacoraError("El espacio "+ nombre + " no esta activo");
            }
        }else if(nombre == "2") //Espacio 2
		{
            if (PlayerPrefs.GetInt("PISO2A") == 1) //Espacio activo
			{
                PlayerPrefs.SetInt("CARGAR", 2);
                SetBitacora("El usuario cargo el espacio " + nombre);
                SceneManager.LoadScene("Espacios");
            }
			else //Espacio inactivo
			{
                SetBitacoraError("El espacio " + nombre + " no esta activo");
            }
        }
		else if(nombre == "3") //Espacio 3
		{
            if (PlayerPrefs.GetInt("PISO3A") == 1) //Espacio activo
			{
                PlayerPrefs.SetInt("CARGAR", 3);
                SetBitacora("El usuario cargo el espacio " + nombre);
                SceneManager.LoadScene("Espacios");
            }
			else //Espacio inactivo
			{
                SetBitacoraError("El espacio " + nombre + " no esta activo");
            }
        }
		else if(nombre == "4") //Espacio 4
		{
            if (PlayerPrefs.GetInt("PISO4A") == 1) //Espacio activo
			{
                PlayerPrefs.SetInt("CARGAR", 4);
                SetBitacora("El usuario cargo el espacio " + nombre);
                SceneManager.LoadScene("Espacios");
            }
			else //Espacio inactivo
			{
                SetBitacoraError("El espacio " + nombre + " no esta activo");
            }
        }
		else if(nombre == "5") //Espacio 5
		{
            if (PlayerPrefs.GetInt("PISO5A") == 1) //Espacio activo
			{
                PlayerPrefs.SetInt("CARGAR", 5);
                SetBitacora("El usuario cargo el espacio " + nombre);
                SceneManager.LoadScene("Espacios");
            }
			else //Espacio inactivo
			{
                SetBitacoraError("El espacio " + nombre + " no esta activo");
            }
        }
		else if(nombre == "6") //Espacio 6
		{
            if (PlayerPrefs.GetInt("PISO6A") == 1) //Espacio activo
			{
                PlayerPrefs.SetInt("CARGAR", 6);
                SetBitacora("El usuario cargo el espacio " + nombre);
                SceneManager.LoadScene("Espacios");
            }
			else //Espacio inactivo
			{
                SetBitacoraError("El espacio " + nombre + " no esta activo");
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
	
}
