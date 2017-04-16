using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setup : MonoBehaviour {

    string[] palabras = { "Balon", "Cesto", "Auto", "Movil", "Puerto", "Aero"," ", " ", " ", " ", " ", " ", " ", " ", " ", " ", };
    bool[] usados;
    public Transform panel;
    public Image WordField;
    Transform hijo;
    Text palabra;
    int word;
    int intentos = 0;
    GameObject go;

    // Use this for initiali1zation
    void Start() {
        usados = new bool[palabras.Length];
        Debug.Log("Max del arreglo de palabras = " + palabras.Length);

        panel = this.transform.GetChild(0);

        for (int i = 0; i < panel.gameObject.transform.childCount; i++) {
            hijo = panel.transform.GetChild(i);
            Instantiate(WordField, hijo);
            word = Random.Range(0, palabras.Length);
            Debug.Log("Numero random = " + word + " || i = " + i + " || Usados en posicion " + i + " = " + usados[word]);   
            if (usados[word] == false) {
                palabra = hijo.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>();
                asignarPalabra(palabra, word);
                usados[word] = true;
                Debug.Log("En i = " + i + " se pudo poner palabra");
            }

            if (usados[word] == true && intentos < usados.Length) {
                intentos++;
                Debug.Log("En i = " + i + " No se pudo poner palabra, i-- seria = " + (i--));
            }
        }
    }

    // Update is called once per frame
    void asignarPalabra(Text t, int i) {
        palabra.text = palabras[i];
    }
}
