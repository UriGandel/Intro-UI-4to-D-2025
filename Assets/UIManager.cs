using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtResultado;
    public TMP_InputField inputClave;
    string claveIngresada;
    string claveCorrecta = "Unity";
    
    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckearClave()
    {

        claveIngresada = inputClave.text;


        if(claveIngresada == claveCorrecta)
        {
            txtResultado.text = "Clave correcta";
        }
        else
        {
            txtResultado.text = "Clave incorrecta";
        }


    }
}
