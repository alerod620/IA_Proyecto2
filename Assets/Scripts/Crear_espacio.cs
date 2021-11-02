using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class Crear_espacio : MonoBehaviour
{
	
	[SerializeField]
    GameObject panelMSG; //Objeto para manipular el panel donde se muestran los mensajes al presionar "agregar"
	
	public Text texto; //Variable para mostra mensaje en el panel
	
	public Dropdown piso_dd;
	public Dropdown sillon_dd;
	public Dropdown mesa_dd;
	public Dropdown sofa_dd;
	public Dropdown lampara_dd;  
	public Dropdown jacuzzi_dd;
	
	private int piso = 0;
	private int sillon = 0;
	private int mesa = 0;
	private int sofa = 0;
	private int lampara = 0;
	private int jacuzzi = 0;
	
	public void setPiso(int piso){this.piso = piso;}
	public void setSillon(int sillon){this.sillon = sillon;}
	public void setMesa(int mesa){this.mesa = mesa;}
	public void setSofa(int sofa){this.sofa = sofa;}
	public void setLampara(int lampara){this.lampara = lampara;}
	public void setJacuzzi(int jacuzzi){this.jacuzzi = jacuzzi;}
	
	public int getPiso(){ return this.piso;}
	public int getSillon(){ return this.sillon;}
	public int getMesa(){ return this.mesa;}
	public int getSofa(){ return this.sofa;}
	public int getLampara(){ return this.lampara;}
	public int getJacuzzi(){ return this.jacuzzi;}
	
    // Start is called before the first frame update
    void Start()
    {
		
		//Cada dropdown tiene su listener y están por orden de como aparecen en la interfaz
		
		//Pisos
        piso_dd.onValueChanged.AddListener(delegate
        {
            CambioValor(piso_dd, 1);
        });
		
		//Sillon
        sillon_dd.onValueChanged.AddListener(delegate
        {
            CambioValor(sillon_dd, 2);
        });
		
		//Mesa
        mesa_dd.onValueChanged.AddListener(delegate
        {
            CambioValor(mesa_dd, 3);
        });
		
		//Sofa
        sofa_dd.onValueChanged.AddListener(delegate
        {
            CambioValor(sofa_dd, 4);
        });
		
		//Lampara
        lampara_dd.onValueChanged.AddListener(delegate
        {
            CambioValor(lampara_dd, 5);
        });
		
		//Jacuzzi
		jacuzzi_dd.onValueChanged.AddListener(delegate
        {
            CambioValor(jacuzzi_dd, 6);
        });
    }

    public void CambioValor(Dropdown sender, int dd){
		
        if(dd == 1) //Pisos
		{
            this.setPiso(sender.value);
        }
		else if (dd == 2) //Sillon
		{
            this.setSillon(sender.value);
        }
		else if (dd == 3) //Mesa
		{
            this.setMesa(sender.value);
        }
		else if (dd == 4) //Sofa
		{//sofa
            this.setSofa(sender.value);
        }
		else if (dd == 5) //Lampara
		{
            this.setLampara(sender.value);
        }
		else if (dd == 6) //Jacuzzi
		{
            this.setJacuzzi(sender.value);
        }
		
    }
	
	//Valida que los muebles estén en posiciones diferentes
	public void validarMuebles(){
		
		if(this.piso == 0 || this.sillon == 0 || this.mesa == 0 || this.sofa == 0 || this.lampara == 0 || this.jacuzzi == 0) //Verifica que se seleccione alguna posición para todos los muebles
		{
			texto.text = "Todos los muebles deben estar en alguna posicion";
			SetBitacoraError("Falta seleccionar valores");
		}
		//Verifica que ningun 
		else if((this.sillon == this.mesa) || (this.sillon == this.sofa) || (this.sillon == this.lampara) || (this.sillon == this.jacuzzi) || (this.mesa == this.sofa) || (this.mesa == this.lampara) || (this.mesa == this.jacuzzi) || (this.sofa == this.lampara) || (this.sofa == this.jacuzzi) || (this.lampara == this.jacuzzi))
		{
			texto.text = "No pueden haber muebles en la misma posicion";
			SetBitacoraError("Hay muebles en la misma posicion");
		}		
		else
		{
			valores();
		}
		
		
	}
	
	
	//Realiza la creación de los espacios
	public void valores(){
		
        if (this.piso == 1) //Crea el espacio 1
		{
            if (PlayerPrefs.GetInt("PISO1A") == 0) //Verifica que no esté ocupado el piso 1
			{
                valoresNuevos("1"); //Setear valores de piso 1
            }
			else //Está ocupado el espacio 1
			{
				texto.text = "El piso 1 ya está ocupado";
                SetBitacoraError("El piso 1 ya está ocupado");
            }
        }
		else if (this.piso == 2) //Crea el espacio 2
		{
            if (PlayerPrefs.GetInt("PISO2A") == 0) //Verifica que no esté ocupado el piso 2
			{
                valoresNuevos("2"); //Setear valores de piso 2
            }
			else //Está ocupado el espacio 2
			{
				texto.text = "El piso 2 ya está ocupado";
                SetBitacoraError("El piso 2 ya está ocupado");
            }
        }
		else if (this.piso == 3) //Crea el espacio 3
		{
            if (PlayerPrefs.GetInt("PISO3A") == 0) //Verifica que no esté ocupado el piso 3
			{
                valoresNuevos("3"); //Setear valores de piso 3
            }
			else //Está ocupado el espacio 3
			{
				texto.text = "El piso 3 ya está ocupado";
                SetBitacoraError("El piso 3 ya está ocupado");
            }
        }
		else if (this.piso == 4) //Crea el espacio 4
		{
            if (PlayerPrefs.GetInt("PISO4A") == 0) //Verifica que no esté ocupado el piso 4
			{
                valoresNuevos("4"); //Setear valores de piso 4
            }
			else //Está ocupado el espacio 4
			{
				texto.text = "El piso 4 ya está ocupado";
                SetBitacoraError("El piso 4 ya está ocupado");
            }
        }
		else if (this.piso == 5) //Crea el espacio 5
		{
            if (PlayerPrefs.GetInt("PISO5A") == 0) //Verifica que no esté ocupado el piso 5
			{
                valoresNuevos("5"); //Setear valores de piso 5
            }
			else //Está ocupado el espacio 5
			{
				texto.text = "El piso 5 ya está ocupado";
                SetBitacoraError("El piso 5 ya está ocupado");
            }
        }
		else if (this.piso == 6) //Crea el espacio 6
		{
            if (PlayerPrefs.GetInt("PISO6A") == 0) //Verifica que no esté ocupado el piso 6
			{
                valoresNuevos("6"); //Setear valores de piso 6
            }
			else //Está ocupado el espacio 6
			{
				texto.text = "El piso 6 ya está ocupado";
                SetBitacoraError("El piso 6 ya está ocupado");
            }
        }
    }
	
	public void valoresNuevos(string piso){
		
        if (piso == "1") //Espacio 1
		{
            PlayerPrefs.SetInt("PISO1A",1);
			texto.text = "Espacio 1 creado con exito";
            SetBitacora("El usuario creo el espacio 1");
        }
		else if (piso == "2") //Espacio 2
		{
            PlayerPrefs.SetInt("PISO2A",1);
			texto.text = "Espacio 2 creado con exito";
            SetBitacora("El usuario creo el espacio 2");
        }
		else if (piso == "3") //Espacio 3
		{
            PlayerPrefs.SetInt("PISO3A",1);
			texto.text = "Espacio 3 creado con exito";
            SetBitacora("El usuario creo el espacio 3");
        }
		else if (piso == "4") //Espacio 4
		{
            PlayerPrefs.SetInt("PISO4A",1);
			texto.text = "Espacio 4 creado con exito";
            SetBitacora("El usuario creo el espacio 4");
        }
		else if (piso == "5") //Espacio 5
		{
            PlayerPrefs.SetInt("PISO5A",1);
			texto.text = "Espacio 5 creado con exito";
            SetBitacora("El usuario creo el espacio 5");
        }
		else if (piso == "6") //Espacio 6
		{
            PlayerPrefs.SetInt("PISO6A",1);
			texto.text = "Espacio 6 creado con exito";
            SetBitacora("El usuario creo el espacio 6");
        }
		
        PlayerPrefs.SetInt("PISO"+piso, this.piso);
		PlayerPrefs.SetInt("SILLON"+piso, this.sillon);
		PlayerPrefs.SetInt("MESA"+piso, this.mesa);
		PlayerPrefs.SetInt("SOFA"+piso, this.sofa);
		PlayerPrefs.SetInt("LAMPARA"+piso, this.lampara);
		PlayerPrefs.SetInt("JACUZZI"+piso, this.jacuzzi);
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
