using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setup : MonoBehaviour {

    string[] palabras1 = { "Balon", "Auto", "Aero", "Auto", "Quita", "Quita" };
    string[] palabras2 = { "Cesto", "Movil", "Puerto", "Pista", "Nieves", "Sol" };
    bool[] usados1;
    bool[] usados2;
    public Transform panel;
    public Image WordField;
    Transform hijo;
    Text palabra;
    int word;

    // Use this for initiali1zation
    void Start() {
        usados1 = new bool[palabras1.Length];
        usados2 = new bool[palabras2.Length];

        panel = this.transform.GetChild(0);

        for (int i = 0; i < panel.gameObject.transform.childCount; i++) {
            hijo = panel.transform.GetChild(i);
            word = Random.Range(0, palabras1.Length);

            if (i % 2 == 0) {
                if (usados1[word] == true) {
                    i--;
                }

                if (usados1[word] == false) {
                    Instantiate(WordField, hijo);
                    palabra = hijo.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>();
                    asignarPalabra(palabra, word, 1);
                    usados1[word] = true; ;
                }
            } else {
                if (usados2[word] == true) {
                    i--;
                }

                if (usados2[word] == false) {
                    Instantiate(WordField, hijo);
                    palabra = hijo.transform.GetChild(0).transform.GetChild(0).GetComponent<Text>();
                    asignarPalabra(palabra, word, 2);
                    usados2[word] = true; ;
                }
            }
        }
    }

    // Update is called once per frame
    void asignarPalabra(Text t, int i, int j) {
        if (j == 1) {
            palabra.text = palabras1[i];
        } else {
            palabra.text = palabras2[i];
        }
    }
}
