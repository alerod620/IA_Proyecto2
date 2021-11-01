using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.IO;

public class Espacios : MonoBehaviour
{
    private int piso = 1;
    private int mesa = 1;
    private int lampara = 1;
    private int jacuzzi = 1;
    private int sillon = 1;
    private int sofa = 1;

    
    public GameObject arcamera1;
    public GameObject arcamera2;
    public GameObject arcamera3;
    public GameObject arcamera4;
    public GameObject arcamera5;
    public GameObject arcamera6;


    public GameObject mesa1;
    public GameObject mesa2;
    public GameObject mesa3;
    public GameObject mesa4;
    public GameObject mesa5;
    public GameObject mesa6;

    public GameObject lampara1;
    public GameObject lampara2;
    public GameObject lampara3;
    public GameObject lampara4;
    public GameObject lampara5;
    public GameObject lampara6;

    public GameObject jacuzzi1;
    public GameObject jacuzzi2;
    public GameObject jacuzzi3;
    public GameObject jacuzzi4;
    public GameObject jacuzzi5;
    public GameObject jacuzzi6;

    public GameObject sillon1;
    public GameObject sillon2;
    public GameObject sillon3;
    public GameObject sillon4;
    public GameObject sillon5;
    public GameObject sillon6;

    public GameObject sofa1;
    public GameObject sofa2;
    public GameObject sofa3;
    public GameObject sofa4;
    public GameObject sofa5;
    public GameObject sofa6;

    // Start is called before the first frame update
    void Start()
    {
        //Obteniendo parametros
        if (PlayerPrefs.GetInt("CARGAR") == 1){
            load("1");
            this.arcamera1.SetActive(true);
            posicionarMesa(this.mesa1);
            posicionarLampara(this.lampara1);
            posicionarJacuzzi(this.jacuzzi1);
            posicionarSillon(this.sillon1);
            posicionarSofa(this.sofa1);
        }else if (PlayerPrefs.GetInt("CARGAR") == 2){
            load("2");
            this.arcamera2
    .SetActive(true);
            this.arcamera2.SetActive(true);
            posicionarMesa(this.mesa2);
            posicionarLampara(this.lampara2);
            posicionarJacuzzi(this.jacuzzi2);
            posicionarSillon(this.sillon2);
            posicionarSofa(this.sofa2);
        }else if (PlayerPrefs.GetInt("CARGAR") == 3){
            load("3");
            this.arcamera3.SetActive(true);
            posicionarMesa(this.mesa3);
            posicionarLampara(this.lampara3);
            posicionarJacuzzi(this.jacuzzi3);
            posicionarSillon(this.sillon3);
            posicionarSofa(this.sofa3);
        }else if (PlayerPrefs.GetInt("CARGAR") == 4){
            load("4");
            this.arcamera4.SetActive(true);
            posicionarMesa(this.mesa4);
            posicionarLampara(this.lampara4);
            posicionarJacuzzi(this.jacuzzi4);
            posicionarSillon(this.sillon4);
            posicionarSofa(this.sofa4);
        }else if (PlayerPrefs.GetInt("CARGAR") == 5){
            load("5");
            this.arcamera5.SetActive(true);
            posicionarMesa(this.mesa5);
            posicionarLampara(this.lampara5);
            posicionarJacuzzi(this.jacuzzi5);
            posicionarSillon(this.sillon5);
            posicionarSofa(this.sofa5); 
        }else if (PlayerPrefs.GetInt("CARGAR") == 6){
            load("6");
            this.arcamera6.SetActive(true);
            posicionarMesa(this.mesa6);
            posicionarLampara(this.lampara6);
            posicionarJacuzzi(this.jacuzzi6);
            posicionarSillon(this.sillon6);
            posicionarSofa(this.sofa6);         
        }else{
            load("1");
            this.arcamera1.SetActive(true);
            posicionarMesa(this.mesa1);
            posicionarLampara(this.lampara1);
            posicionarJacuzzi(this.jacuzzi1);
            posicionarSillon(this.sillon1);
            posicionarSofa(this.sofa1);
        }



        print("****************************************");
        print("El piso es: "+ this.piso.ToString());
        print("La mesa es: "+ this.mesa.ToString());
        print("La lampara es: "+ this.lampara.ToString());
        print("El sillon es: "+ this.sillon.ToString());
        print("El sofa es: "+ this.sofa.ToString());
        print("El jacuzzi es: "+ this.jacuzzi.ToString());
        print("****************************************");
    }

    public void load(string N){
        this.piso = PlayerPrefs.GetInt("PISO"+N,1);
        this.mesa = PlayerPrefs.GetInt("MESA"+N,1);
        this.lampara = PlayerPrefs.GetInt("LAMPARA"+N,1);
        this.sillon = PlayerPrefs.GetInt("SILLON"+N,1);
        this.sofa = PlayerPrefs.GetInt("SOFA"+N,1);
        this.jacuzzi = PlayerPrefs.GetInt("JACUZZI"+N,1);

    }

   
    void Update()
    {
         //Con la tecla espacio regresamos al usuario al menu principal
        if (Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene("Menu");
        }
        
    }

    public void posicionarMesa(GameObject mesaO){
        print("++++++++++++++++++++++++++++++++++");
        print(mesaO.transform.position);
        switch (this.mesa){            
            // Superior izquierda
            case 1:
                mesaO.transform.position = new Vector3(mesaO.transform.position.x+(-4.8f),
                mesaO.transform.position.y,
                mesaO.transform.position.z+(5.5f));
                break;
            //Superior derecha
            case 2:
                mesaO.transform.position = new Vector3(mesaO.transform.position.x+(4.8f),
                mesaO.transform.position.y,
                mesaO.transform.position.z+(5.5f));
                break;
            //Centro
            case 3:
                mesaO.transform.position = new Vector3(mesaO.transform.position.x,
                mesaO.transform.position.y,
                mesaO.transform.position.z);
                break;
            //Inferior izquierda
            case 4:
                mesaO.transform.position = new Vector3(mesaO.transform.position.x+(-4.8f),
                mesaO.transform.position.y,
                mesaO.transform.position.z+(-5.5f));
                break;
            //Inferior derecha
            case 5:
                mesaO.transform.position = new Vector3(mesaO.transform.position.x+(4.8f),
                mesaO.transform.position.y,
                mesaO.transform.position.z+(-5.5f));
                break;
            default:
                mesaO.transform.position = new Vector3(mesaO.transform.position.x,
                mesaO.transform.position.y,
                mesaO.transform.position.z);
                break;
        }
        print(mesaO.transform.position);
        print("++++++++++++++++++++++++++++++++++");
    }

    public void posicionarLampara(GameObject lamparaO){
         print("++++++++++++++++++++++++++++++++++****");
        print(lamparaO.transform.position);
        
        switch (this.lampara){            
            // Superior izquierda
            case 1:
                lamparaO.transform.position = new Vector3(lamparaO.transform.position.x+(-4.8f),
                lamparaO.transform.position.y,
                lamparaO.transform.position.z+(5.5f));
                break;
            //Superior derecha
            case 2:
                lamparaO.transform.position = new Vector3(lamparaO.transform.position.x+(4.8f),
                lamparaO.transform.position.y,
                lamparaO.transform.position.z+(5.5f));
                break;
            //Centro
            case 3:
                lamparaO.transform.position = new Vector3(lamparaO.transform.position.x,
                lamparaO.transform.position.y,
                lamparaO.transform.position.z);
                break;
            //Inferior izquierda
            case 4:
                lamparaO.transform.position = new Vector3(lamparaO.transform.position.x+(-4.8f),
                lamparaO.transform.position.y,
                lamparaO.transform.position.z+(-5.5f));
                break;
            //Inferior derecha
            case 5:
                lamparaO.transform.position = new Vector3(lamparaO.transform.position.x+(4.8f),
                lamparaO.transform.position.y,
                lamparaO.transform.position.z+(-5.5f));
                break;
            default:
                lamparaO.transform.position = new Vector3(lamparaO.transform.position.x,
                lamparaO.transform.position.y,
                lamparaO.transform.position.z);
                break;
        }
        print(lamparaO.transform.position);
        print("++++++++++++++++++++++++++++++++++****");
    }

 

 public void posicionarJacuzzi(GameObject jacuzziO){
         print("++++++++++++++++++++++++++++++++++****");
        print(jacuzziO.transform.position);
        
        switch (this.jacuzzi){            
            // Superior izquierda
            case 1:
                jacuzziO.transform.position = new Vector3(jacuzziO.transform.position.x+(-4.8f),
                jacuzziO.transform.position.y,
                jacuzziO.transform.position.z+(5.5f));
                break;
            //Superior derecha
            case 2:
                jacuzziO.transform.position = new Vector3(jacuzziO.transform.position.x+(4.8f),
                jacuzziO.transform.position.y,
                jacuzziO.transform.position.z+(5.5f));
                break;
            //Centro
            case 3:
                jacuzziO.transform.position = new Vector3(jacuzziO.transform.position.x,
                jacuzziO.transform.position.y,
                jacuzziO.transform.position.z);
                break;
            //Inferior izquierda
            case 4:
                jacuzziO.transform.position = new Vector3(jacuzziO.transform.position.x+(-4.8f),
                jacuzziO.transform.position.y,
                jacuzziO.transform.position.z+(-5.5f));
                break;
            //Inferior derecha
            case 5:
                jacuzziO.transform.position = new Vector3(jacuzziO.transform.position.x+(4.8f),
                jacuzziO.transform.position.y,
                jacuzziO.transform.position.z+(-5.5f));
                break;
            default:
                jacuzziO.transform.position = new Vector3(jacuzziO.transform.position.x,
                jacuzziO.transform.position.y,
                jacuzziO.transform.position.z);
                break;
        }
        print(jacuzziO.transform.position);
        print("++++++++++++++++++++++++++++++++++****");
    }


    public void posicionarSillon(GameObject sillonO){
         print("++++++++++++++++++++++++++++++++++****");
        print(sillonO.transform.position);
        
        switch (this.sillon){            
            // Superior izquierda
            case 1:
                sillonO.transform.position = new Vector3(sillonO.transform.position.x+(-4.8f),
                sillonO.transform.position.y,
                sillonO.transform.position.z+(5.5f));
                break;
            //Superior derecha
            case 2:
                sillonO.transform.position = new Vector3(sillonO.transform.position.x+(4.8f),
                sillonO.transform.position.y,
                sillonO.transform.position.z+(5.5f));
                break;
            //Centro
            case 3:
                sillonO.transform.position = new Vector3(sillonO.transform.position.x,
                sillonO.transform.position.y,
                sillonO.transform.position.z);
                break;
            //Inferior izquierda
            case 4:
                sillonO.transform.position = new Vector3(sillonO.transform.position.x+(-4.8f),
                sillonO.transform.position.y,
                sillonO.transform.position.z+(-5.5f));
                break;
            //Inferior derecha
            case 5:
                sillonO.transform.position = new Vector3(sillonO.transform.position.x+(4.8f),
                sillonO.transform.position.y,
                sillonO.transform.position.z+(-5.5f));
                break;
            default:
                sillonO.transform.position = new Vector3(sillonO.transform.position.x,
                sillonO.transform.position.y,
                sillonO.transform.position.z);
                break;
        }
        print(sillonO.transform.position);
        print("++++++++++++++++++++++++++++++++++****");
    }


     public void posicionarSofa(GameObject sofaO){
         print("++++++++++++++++++++++++++++++++++****");
        print(sofaO.transform.position);
        
        switch (this.sofa){            
            // Superior izquierda
            case 1:
                sofaO.transform.position = new Vector3(sofaO.transform.position.x+(-4.8f),
                sofaO.transform.position.y,
                sofaO.transform.position.z+(5.5f));
                break;
            //Superior derecha
            case 2:
                sofaO.transform.position = new Vector3(sofaO.transform.position.x+(4.8f),
                sofaO.transform.position.y,
                sofaO.transform.position.z+(5.5f));
                break;
            //Centro
            case 3:
                sofaO.transform.position = new Vector3(sofaO.transform.position.x,
                sofaO.transform.position.y,
                sofaO.transform.position.z);
                break;
            //Inferior izquierda
            case 4:
                sofaO.transform.position = new Vector3(sofaO.transform.position.x+(-4.8f),
                sofaO.transform.position.y,
                sofaO.transform.position.z+(-5.5f));
                break;
            //Inferior derecha
            case 5:
                sofaO.transform.position = new Vector3(sofaO.transform.position.x+(4.8f),
                sofaO.transform.position.y,
                sofaO.transform.position.z+(-5.5f));
                break;
            default:
                sofaO.transform.position = new Vector3(sofaO.transform.position.x,
                sofaO.transform.position.y,
                sofaO.transform.position.z);
                break;
        }
        print(sofaO.transform.position);
        print("++++++++++++++++++++++++++++++++++****");
    }

  

}
