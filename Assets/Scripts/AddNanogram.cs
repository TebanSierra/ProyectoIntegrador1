using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

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
    private ChosenNonogram chosenGram;
    List<ChosenNonogram> nonogramList = new List<ChosenNonogram>();


    private byte[,] puzzle;

    //Funcion que es llamada cuando se inica el juego
    void Awake() {
        getNonograms();
        chooseNonogram();
        rows = chosenGram.getRows();
        nonogramSize = chosenGram.getTotalHeight() * chosenGram.getTotalSize();
        nonogramField.GetComponent<GridLayoutGroup>().constraintCount = chosenGram.getTotalSize() + chosenGram.getRow(); ;
        fillUpperHints();
        fillRest();
    }

    void fillUpperHints() {
        int x = 0;
        while (x < chosenGram.getRow() *(chosenGram.getCols()+chosenGram.getRow())) {
            foreach (string[] row in rows) {
                for (int i = 0; i < chosenGram.getRow(); i++) {
                    hints.GetComponent<Text>().text = "";
                    GameObject text = Instantiate(hints);
                    text.name = "empty" + i;
                    text.transform.SetParent(nonogramField, false);
                    x++;
                }

                for (int i = 0; i < chosenGram.getTotalSize(); i++) {
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
        columns = chosenGram.getCol();
        while (x < nonogramSize + (chosenGram.getRow() * chosenGram.getCols())) {
            for (int i = 0; i <chosenGram.getTotalHeight(); i++) {
                foreach (string[] column in columns) {
                    hints.GetComponent<Text>().text = column[i];
                    GameObject text = Instantiate(hints);
                    text.name = "column" + tot;
                    text.transform.SetParent(nonogramField, false);
                    x++;
                    tot++;
                }

                for (int j = 0; j < chosenGram.getTotalSize(); j++) {
                    GameObject piece = Instantiate(nonogramPiece);
                    piece.name = m.ToString();
                    piece.transform.SetParent(nonogramField, false);
                    m++;
                    x++;
                }
            }
        }
    }

    void getNonograms() {
        nonogramList.Add(nonogramPuzzle.GetComponent<KeyNonogram>());
        nonogramList.Add(nonogramPuzzle.GetComponent<TVNonogram>());
        nonogramList.Add(nonogramPuzzle.GetComponent<MusicNonogram>());
    }

    void chooseNonogram() {
        int index = Random.Range(0, nonogramList.Count);
        chosenGram = nonogramList.ElementAt(index);
    }

    public ChosenNonogram getChosenNonogram() {
        return chosenGram;
    }
}
