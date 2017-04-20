using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddNanogram : MonoBehaviour {

    //Serialize permite que la variable pueda ser modificada en Unity sin necesidad de que esta sea Publica. (To simplify things, not having to call them through code)
    [SerializeField]
    //Variable que contendra la posicion donde sera creado el Juego.
    private Transform nonogramField;

    [SerializeField]
    private GameObject nonogramPiece;

    [SerializeField]
    private GameObject hints;

    [SerializeField]
    private int nonogramSize;
    private int nonogramHeight;
    private int monogramWidth;
    private int cols;
    [SerializeField]
    private GameObject nonogramPuzzle;
    public List<string[]> rows;
    private List<string[]> columns;


    private byte[,] puzzle;

    //Funcion que es llamada cuando se inica el juego
    void Awake() {
        rows = nonogramPuzzle.GetComponent<KeyNonogram>().getRows();
        fillUpperHints();
        fillRest();
    }

    void fillUpperHints() {
        int x = 0;
        while (x < nonogramPuzzle.GetComponent<KeyNonogram>().getRow() *(nonogramPuzzle.GetComponent<KeyNonogram>().getCols()+ nonogramPuzzle.GetComponent<KeyNonogram>().getRow())) {
            foreach (string[] row in rows) {
                for (int i = 0; i < nonogramPuzzle.GetComponent<KeyNonogram>().getRow(); i++) {
                    hints.GetComponent<Text>().text = "";
                    GameObject text = Instantiate(hints);
                    text.name = "empty" + i;
                    text.transform.SetParent(nonogramField, false);
                    x++;
                }

                for (int i = 0; i < nonogramPuzzle.GetComponent<KeyNonogram>().getTotalSize(); i++) {
                    hints.GetComponent<Text>().text = row[i];
                    GameObject text = Instantiate(hints);
                    text.name = "row" + i;
                    text.transform.SetParent(nonogramField, false);
                    x++;
                }

            }
        }
    }

    void fillRest() {
        int x = 0;
        int m = 0;
        int tot = 0;
        columns = nonogramPuzzle.GetComponent<KeyNonogram>().getCol();
        while (x < nonogramSize + (nonogramPuzzle.GetComponent<KeyNonogram>().getRow() * nonogramPuzzle.GetComponent<KeyNonogram>().getCols())) {
            for (int i = 0; i < nonogramPuzzle.GetComponent<KeyNonogram>().getTotalHeight(); i++) {
                foreach (string[] column in columns) {
                    hints.GetComponent<Text>().text = column[i];
                    GameObject text = Instantiate(hints);
                    text.name = "column" + tot;
                    text.transform.SetParent(nonogramField, false);
                    x++;
                    tot++;
                }

                for (int j = 0; j < nonogramPuzzle.GetComponent<KeyNonogram>().getTotalSize(); j++) {
                    GameObject piece = Instantiate(nonogramPiece);
                    piece.name = m.ToString();
                    piece.transform.SetParent(nonogramField, false);
                    m++;
                    x++;
                }
            }
        }
    }
}
