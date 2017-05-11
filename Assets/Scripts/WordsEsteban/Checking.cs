using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Checking : MonoBehaviour {

    string[] respuestas = { "Automovil", "Baloncesto", "Aeropuerto", "Quitanieves", "Quitasol", "Autopista" };
    [SerializeField]
    Button btn;
    //[SerializeField]
    //public Image rta;
    [SerializeField]
    private GameObject Win;

    Transform padre;
    Transform panel;
    Transform panel2;
    Transform wz;

    string parte1;
    string parte2;

    string resultado;

    int correctas = 0;
    int puntaje;

    private void Start() {
        btn.onClick.AddListener(check);
    }

    // Use this for initialization
    public void check() {
        panel = btn.transform.parent;
        panel2 = panel.transform.GetChild(1);

        for (int i = 0; i < panel2.childCount; i++) {
            wz = panel2.transform.GetChild(i);
            Transform p1;
            Transform p2;
            p1 = wz.transform.GetChild(0);
            p2 = wz.transform.GetChild(1);
            parte1 = p1.transform.GetChild(0).GetComponent<Text>().text;
            p2 = wz.transform.GetChild(1);
            parte2 = p2.transform.GetChild(0).GetComponent<Text>().text;
            resultado = parte1 + parte2.ToLower();

            for (int j = 0; j < respuestas.Length; j++) {
                if (resultado == respuestas[j])
                    correctas++;
            }
        }

        puntaje = (100 * correctas) / panel.transform.GetChild(1).childCount;
        Text rtaText;
        rtaText = Win.transform.GetChild(1).GetComponent<Text>();
        rtaText.text = correctas + "/" + panel.transform.GetChild(1).childCount;
        //rta.GetComponent<Image>().color = Color.black;
        StartCoroutine(winner());
      
    }
    public IEnumerator winner()
    {
        GameObject text = Instantiate(Win);
        text.transform.SetParent(panel, false);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("LevelSelec");

           
    }
}
