using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class Editar_espacio : MonoBehaviour
{
	
	[SerializeField]
    GameObject panelMSG; //Objeto para manipular el panel donde se muestran los mensajes al presionar "agregar"
	
	public Text texto; //Variable para mostra mensaje en el panel
	public Text espacio; //Mostrará el nombre del espacio que se está editando
	
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
        if(PlayerPrefs.GetInt("EDITAR") == 1) //Espacio 1
		{
			load("1");
			espacio.text = "Editando Espacio 1";
		}
		else if(PlayerPrefs.GetInt("EDITAR") == 2) //Espacio 2
		{
			load("2");
			espacio.text = "Editando Espacio 2";
		}
		else if(PlayerPrefs.GetInt("EDITAR") == 3) //Espacio 3
		{
			load("3");
			espacio.text = "Editando Espacio 3";
		}
		else if(PlayerPrefs.GetInt("EDITAR") == 4) //Espacio 4
		{
			load("4");
			espacio.text = "Editando Espacio 4";
		}
		else if(PlayerPrefs.GetInt("EDITAR") == 5) //Espacio 5
		{
			load("5");
			espacio.text = "Editando Espacio 5";
		}
		else if(PlayerPrefs.GetInt("EDITAR") == 6) //Espacio 6
		{
			load("6");
			espacio.text = "Editando Espacio 6";
		}
		
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
	
	public void load(string N){
        this.piso = PlayerPrefs.GetInt("PISO"+N,1);
        this.mesa = PlayerPrefs.GetInt("MESA"+N,1);
        this.lampara = PlayerPrefs.GetInt("LAMPARA"+N,1);
        this.sillon = PlayerPrefs.GetInt("SILLON"+N,1);
        this.sofa = PlayerPrefs.GetInt("SOFA"+N,1);
        this.jacuzzi = PlayerPrefs.GetInt("JACUZZI"+N,1);

		sillon_dd.value = this.sillon;
		mesa_dd.value = this.mesa;
		sofa_dd.value = this.sofa;
		lampara_dd.value = this.lampara;
		jacuzzi_dd.value = this.jacuzzi;

    }
	
	public void CambioValor(Dropdown sender, int dd){
		
        if (dd == 2) //Sillon
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
		
		if(this.sillon == 0 || this.mesa == 0 || this.sofa == 0 || this.lampara == 0 || this.jacuzzi == 0) //Verifica que se seleccione alguna posición para todos los muebles
		{
			texto.text = "Todos los muebles deben estar en alguna posicion";
			SetBitacoraError("Falta seleccionar valores");
		}
		//Verifica que todos los muebles se encuentren en diferentes posiciones
		else if((this.sillon == this.mesa) || (this.sillon == this.sofa) || (this.sillon == this.lampara) || (this.sillon == this.jacuzzi) || (this.mesa == this.sofa) || (this.mesa == this.lampara) || (this.mesa == this.jacuzzi) || (this.sofa == this.lampara) || (this.sofa == this.jacuzzi) || (this.lampara == this.jacuzzi))
		{
			texto.text = "No pueden haber muebles en la misma posicion";
			SetBitacoraError("Hay muebles en la misma posicion");
		}		
		else
		{
			valoresNuevos();
		}
		
		
	}
	
	
	public void valoresNuevos(){
		
        if (this.piso == 1) //Espacio 1
		{
            PlayerPrefs.SetInt("PISO1A",1);
			texto.text = "Espacio 1 modificado con exito";
            SetBitacora("El usuario modifico el espacio 1");
        }
		else if (this.piso == 2) //Espacio 2
		{
            PlayerPrefs.SetInt("PISO2A",1);
			texto.text = "Espacio 2 modificado con exito";
            SetBitacora("El usuario modifico el espacio 2");
        }
		else if (this.piso == 3) //Espacio 3
		{
            PlayerPrefs.SetInt("PISO3A",1);
			texto.text = "Espacio 3 modificado con exito";
            SetBitacora("El usuario modifico el espacio 3");
        }
		else if (this.piso == 4) //Espacio 4
		{
            PlayerPrefs.SetInt("PISO4A",1);
			texto.text = "Espacio 4 modificado con exito";
            SetBitacora("El usuario modifico el espacio 4");
        }
		else if (this.piso == 5) //Espacio 5
		{
            PlayerPrefs.SetInt("PISO5A",1);
			texto.text = "Espacio 5 modificado con exito";
            SetBitacora("El usuario modifico el espacio 5");
        }
		else if (this.piso == 6) //Espacio 6
		{
            PlayerPrefs.SetInt("PISO6A",1);
			texto.text = "Espacio 6 modificado con exito";
            SetBitacora("El usuario modifico el espacio 6");
        }
		
        PlayerPrefs.SetInt("PISO"+this.piso, this.piso);
		PlayerPrefs.SetInt("SILLON"+this.piso, this.sillon);
		PlayerPrefs.SetInt("MESA"+this.piso, this.mesa);
		PlayerPrefs.SetInt("SOFA"+this.piso, this.sofa);
		PlayerPrefs.SetInt("LAMPARA"+this.piso, this.lampara);
		PlayerPrefs.SetInt("JACUZZI"+this.piso, this.jacuzzi);
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
