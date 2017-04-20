using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public List<Button> buttons = new List<Button>();

    [SerializeField]
    private Color blackColor = Color.black;
    private Color whiteColor = Color.white;

    string a = "LevelSelec";
    private float time;
    private bool pressed;
    private int pressedIndex;
    private int totalCheck;
    byte[,] currentPuzzle;
    byte[,] correctPuzzle;
    [SerializeField]
    private GameObject nonogramPuzzle;
    private int puzzleHeight;
    private int puzzleWidth;
    private int puzzleSize;
    [SerializeField]
    private GameObject Win;
    [SerializeField]
    //Variable que contendra la posicion donde sera creado el Juego.
    private Transform canvas;

    void Start() {
        getButtons();
        addListener();
        puzzleHeight = nonogramPuzzle.GetComponent<KeyNonogram>().getTotalHeight();
        puzzleWidth = nonogramPuzzle.GetComponent<KeyNonogram>().getTotalSize();
        correctPuzzle = new byte[puzzleHeight,puzzleWidth];
        currentPuzzle = new byte[puzzleHeight, puzzleWidth];
        correctPuzzle = nonogramPuzzle.GetComponent<KeyNonogram>().getResult();
        puzzleSize = nonogramPuzzle.GetComponent<KeyNonogram>().getPuzzleSize();
    }

    void getButtons() {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleButton");
        for (int i = 0; i < objects.Length; i++) {
            buttons.Add(objects[i].GetComponent<Button>());
        }
    }

    void addListener() {
        foreach (Button button in buttons) {
            button.onClick.AddListener(pickPuzzle);
        }
    }

    public void pickPuzzle() {
        totalCheck++;
        int i = 0;
        int x = 0;
        string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        pressedIndex = int.Parse(name);
        bool pressed = buttons[pressedIndex].GetComponent<Nonogram>().getPressed();
        if (!pressed) {
            buttons[pressedIndex].image.color = blackColor;
            buttons[pressedIndex].GetComponent<Nonogram>().setPressed(true);
            i = pressedIndex;
            while (i>11) {
                i=i - 12;
                x++;
            }
            currentPuzzle[x,pressedIndex%puzzleWidth] = 1;
            i = 0;
            if (totalCheck >= puzzleSize) {
                if (samePuzzle()) {

                    GameObject text = Instantiate(Win);
                    text.transform.SetParent(canvas, false);
                    
                    SceneManager.LoadScene(a);
                }
            }
        }else {
            buttons[pressedIndex].image.color = whiteColor;
            buttons[pressedIndex].GetComponent<Nonogram>().setPressed(false);
            i = pressedIndex;
            while (i > 11) {
                i = i - 12;
                x++;
            }
            currentPuzzle[x, pressedIndex%puzzleWidth] = 0;
            i = 0;
            if (totalCheck >= puzzleSize) {
                if (samePuzzle()) {
                    GameObject text = Instantiate(Win);
                    text.transform.SetParent(canvas, false);
                   
                    SceneManager.LoadScene(a);
                    
                }
            }
        }
    }

    public bool samePuzzle() {
        string current = "";
        string correct = "";
        for (int y = 0; y < puzzleHeight; y++) {
            for (int i = 0; i < puzzleWidth; i++) {
                if (y == 5 && i != 2 && i != 3 && i != 4) {
                    current = current + "1";
                } else {
                    current = current + currentPuzzle[y, i];
                }
            }
        }

        current.Trim();
        for (int y = 0; y < puzzleHeight; y++) {
            for (int i = 0; i < puzzleWidth; i++) {
                correct = correct + correctPuzzle[y, i];
            }
        }
        correct.Trim();
        if (current.Equals(correct)) {
            return true;
        }
        return false;

        //bool equal = correctPuzzle.Rank == currentPuzzle.Rank &&
        //    Enumerable.Range(0, correctPuzzle.Rank).All(dimension => correctPuzzle.GetLength(dimension) == currentPuzzle.GetLength(dimension)) &&
        //    correctPuzzle.Cast<byte>().SequenceEqual(currentPuzzle.Cast<byte>());

        //return equal;
    }
}
